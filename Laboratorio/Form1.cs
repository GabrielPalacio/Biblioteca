using System.Windows.Forms;
using static Biblioteca.Utilidades;
namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private Vector_Estado fila_actual = new Vector_Estado(); //Fila nueva

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargamos tablade probabilidades
            dgvTablaProbabilidad.Rows.Insert(0, "Prestamo", 0.45, 0.45, 0, 0.45);
            dgvTablaProbabilidad.Rows.Insert(1, "Consulta", 0.45, 0.90, 0.45, 0.90);
            dgvTablaProbabilidad.Rows.Insert(2, "Devolucion", 0.10, 1, 0.9, 1);
        }

        private void btnCalcularTabla_Click(object sender, EventArgs e)
        {
            List<TablaProbabilidad> tp = dgvToList(dgvTablaProbabilidad);
            graficarTablas(tp, dgvTablaProbabilidad);
            btnSimular.Enabled = true;
        }
        private void graficarTablas(List<TablaProbabilidad> lista, DataGridView dgv)
        {
            //Cargamos tablas - Tiro 1
            dgv.Rows.Clear();
            int i = 0;
            double PrAc = 0.00;
            Double desde = 0.00;
            foreach (TablaProbabilidad tp in lista)
            {
                if (i == 0)
                {
                    dgv.Rows.Insert(i, tp.Operacion, tp.Pr, tp.Pr, 0.00, tp.Pr);
                    desde = desde + tp.Pr;
                    PrAc = tp.Pr;
                    i++;
                }
                else
                {
                    PrAc = PrAc + tp.Pr;
                    dgv.Rows.Insert(i, tp.Operacion, tp.Pr, PrAc, desde, PrAc);
                    desde = desde + tp.Pr;
                    i++;
                }
            }

        }
        private bool validarTablasPR(DataGridView grilla)
        {
            bool valido = true;
            double sumaPR = 0;
            foreach (DataGridViewRow row in grilla.Rows)
            {
                sumaPR = sumaPR + Convert.ToDouble(row.Cells[2].Value);
            }
            if (sumaPR != 1)
            {
                valido = false;
                MessageBox.Show("Validar suma de probabilidades.");
                btnSimular.Enabled = false;
            }
            return valido;
        }
        private List<TablaProbabilidad> dgvToList(DataGridView grilla)
        {
            List<TablaProbabilidad> lista = new List<TablaProbabilidad>();

            foreach (DataGridViewRow row in grilla.Rows)
            {
                TablaProbabilidad tp = new TablaProbabilidad();
                tp.Operacion = Convert.ToInt16(row.Cells[0].Value);
                tp.Pr = truncar(Convert.ToDouble(row.Cells[1].Value));
                tp.Pr_acum = truncar(Convert.ToDouble(row.Cells[2].Value));

                lista.Add(tp);
            }
            return lista;

        }
        private List<TablaProbabilidad> dgvProbabilidadesToList(DataGridView grilla)
        {
            List<TablaProbabilidad> lista = new List<TablaProbabilidad>();

            foreach (DataGridViewRow row in grilla.Rows)
            {
                TablaProbabilidad tp = new TablaProbabilidad();

                switch (Convert.ToInt32(row.Cells[0].Value))
                {
                    case 1:
                        tp.NombreOperacion = TipoOperacion.CAMBIO_PLACA;
                        break;
                    case 2:
                        tp.NombreOperacion = TipoOperacion.AMPLICACION_MEMORIA;
                        break;
                    case 3:
                        tp.NombreOperacion = TipoOperacion.FORMATEO_DISCO;
                        break;
                    case 4:
                        tp.NombreOperacion = TipoOperacion.AGREGAR_CD_O_DVD;
                        break;
                    case 5:
                        tp.NombreOperacion = TipoOperacion.CAMBIO_MEMORIA;
                        break;

                }

                tp.Pr = truncar(Convert.ToDouble(row.Cells[1].Value));
                tp.Pr_acum = truncar(Convert.ToDouble(row.Cells[2].Value));

                lista.Add(tp);
            }
            return lista;
        }

        private void Simular_Click(object sender, EventArgs e)
        {
            //validamos tablas de probabilidad
            if (validarTablasPR(dgvTablaProbabilidad) != true)
            {   //Si no retorna true, se frena la ejecución
                return;
            }

            //Limpiamos grillas
            dataGridView1.Rows.Clear();
            eliminarColumnasComputadoras();
            txtPromedioPermanencia.Text = "";
            txtPorcentaje.Text = "";


            //validaciones de campos para que no permita que queden vacios, no revisa iteracciones y tiempo
            validarCamposCompletados();

            Double tiempo_desde = Convert.ToDouble(txtDesde.Text);
            Double tiempo_hasta = Convert.ToDouble(txtHasta.Text);
            Double tiempo = Convert.ToDouble(txtTiempo.Text);
            Int64 iteraciones = Convert.ToInt64(txtIteraciones.Text);
            Double intervaloB = Convert.ToDouble(txtIntervaloB.Text);
            Double intervaloA = Convert.ToDouble(txtIntervaloA.Text);
            Double tiempoLlegada = Convert.ToDouble(txtTiempoEntreLlegada.Text);
            Double tiempo_final = Convert.ToDouble(txtRetorno.Text);

            //Para el manejo de las filas
            fila_actual = new Vector_Estado();

            List<TablaProbabilidad> tablaProbabilidads = dgvProbabilidadesToList(dgvTablaProbabilidad);

            Int64 i = 0;
            for (; i <= iteraciones && this.fila_actual.Reloj <= tiempo; i++)
            {
                string nombre_prox_evento = obtener_proximo_evento();

                switch (nombre_prox_evento)
                {
                    case EventoBiblioteca.INICIO:
                        this.fila_actual.evento_inicio(tiempoLlegada);
                        break;

                    case EventoBiblioteca.LLEGADA_CLIENTE:
                        this.fila_actual.evento_proxima_llegada_computadora(tablaProbabilidads, intervaloA, intervaloB, tiempo_formateo_inicial, tiempo_final);
                        break;

                    case EventoBiblioteca.FIN_FORMATEO_INICIAL:
                        this.fila_actual.evento_fin_formateo_inicial(tablaProbabilidads, intervaloA, intervaloB, tiempo_formateo_inicial, tiempo_final);
                        break;

                    case EventoBiblioteca.FIN_ATENCION_DEVOLUCION:
                        this.fila_actual.evento_fin_formateo_sin_tecnico(tablaProbabilidads, intervaloA, intervaloB, tiempo_final);
                        break;

                    case EventoBiblioteca.FIN_LECTURA:
                        this.fila_actual.evento_fin_atencion(tablaProbabilidads, intervaloA, intervaloB, tiempo_formateo_inicial, tiempo_final);
                        break;
                }

                //Calculos estadisticos
                this.fila_actual.calcular_tiempo_promedio_permanencia();
                this.fila_actual.calcular_porcentaje_equipos_no_atendidos();


                if (this.fila_actual.Reloj >= tiempo_desde && this.fila_actual.Reloj <= tiempo_hasta)
                {
                    agregarFila(i, fila_actual);
                }
            }

            if (dataGridView1.Rows.Count != i)
            {
                agregarFila(i, fila_actual);
            }

            //Se agregar los resultados a los textbox
            txtPromedioPermanencia.Text = fila_actual.Promedio_permanencia_equipo.ToString("N4");
            txtPorcentaje.Text = fila_actual.Promedio_PC_NO_atendidas.ToString("P");
        }

        private void eliminarColumnasComputadoras()
        {
            String nameColumn = "cComputadora";

            for (int i = dataGridView1.Columns.Count - 1; i >= 0; i--)
            {
                DataGridViewColumn column = dataGridView1.Columns[i];
                if (column.Name.Contains(nameColumn))
                {
                    dataGridView1.Columns.Remove(column);
                }
            }
        }

        private void validarCamposCompletados()
        {
            if (String.IsNullOrWhiteSpace(txtDesde.Text))
            {
                MessageBox.Show("Debe ingresar un valor válido para la cantidad desde");
                txtDesde.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtHasta.Text))
            {
                MessageBox.Show("Debe ingresar un valor válido para la cantidad hasta");
                txtHasta.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtIntervaloA.Text))
            {
                MessageBox.Show("Debe ingresar un valor válido el valor menor del intevalo de la uniforme");
                txtIntervaloA.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtIntervaloB.Text))
            {
                MessageBox.Show("Debe ingresar un valor válido el valor mayor del intevalo de la uniforme");
                txtIntervaloB.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPrDeRetiro.Text))
            {
                MessageBox.Show("Debe ingresar un valor válido para la cantidad de minutos que lleva el inicio de formateo");
                txtPrDeRetiro.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtRetorno.Text))
            {
                MessageBox.Show("Debe ingresar un valor válido para la cantidad de minutos que lleva el fin de formateo");
                txtRetorno.Focus();
                return;
            }
            //validacion de desde mayor que iteraciones
            if ((int.Parse(txtDesde.Text)) > int.Parse(txtIteraciones.Text))
            {
                {
                    MessageBox.Show("El valor desde no puede ser superior al de cantidad de Iteraciones.");
                    txtDesde.Clear();
                    txtDesde.Focus();
                    return;
                }
            }
            //validacion de desde mayor que hasta
            if ((int.Parse(txtDesde.Text)) > int.Parse(txtHasta.Text))
            {
                {
                    MessageBox.Show("El valor desde no puede ser superior al de hasta.");
                    txtHasta.Clear();
                    txtHasta.Focus();
                    return;
                }
            }
        }

        private string obtener_proximo_evento()
        {
            double tiempo_min = Double.MaxValue;
            string nombre_evento = "";

            if (fila_actual.Reloj == 0 && fila_actual.Evento == "")
            {
                tiempo_min = fila_actual.Reloj;
                nombre_evento = EventoBiblioteca.INICIO;
            }

            if (fila_actual.Tiempo_llegada > 0 && fila_actual.Tiempo_llegada < tiempo_min)
            {
                tiempo_min = fila_actual.Tiempo_llegada;
                nombre_evento = EventoBiblioteca.LLEGADA_CLIENTE;
            }

            if (fila_actual.Fin_formateo_inicial > 0 && fila_actual.Fin_formateo_inicial < tiempo_min)
            {
                tiempo_min = fila_actual.Fin_formateo_inicial;
                nombre_evento = EventoBiblioteca.FIN_FORMATEO_INICIAL;
            }


            for (int i = 0; i < this.fila_actual.Tiempo_puesto.Count; i++)
            {
                if (this.fila_actual.Tiempo_puesto[i] > 0 && this.fila_actual.Tiempo_puesto[i] < tiempo_min)
                {
                    tiempo_min = this.fila_actual.Tiempo_puesto[i];
                    nombre_evento = EventoBiblioteca.FIN_ATENCION_DEVOLUCION;
                }
            }


            if (fila_actual.Fin_atencion > 0 && fila_actual.Fin_atencion < tiempo_min)
            {
                tiempo_min = fila_actual.Fin_atencion;
                nombre_evento = EventoBiblioteca.FIN_LECTURA;
            }


            return nombre_evento;
        }

        private void agregarFila(Int64 nroFila, Vector_Estado fila, bool visible = true)
        {
            dataGridView1.Rows.Add(
                    nroFila,
                    fila.Reloj.ToString("N4"),
                    fila.Evento,
                    (fila.Rnd_llegada == 0) ? "" : fila.Rnd_llegada.ToString("N4"),
                    (fila.Tiempo_entre_llegada == 0) ? "" : fila.Tiempo_entre_llegada.ToString(),
                    (fila.Tiempo_llegada == 0) ? "" : fila.Tiempo_llegada.ToString("N4"),
                    (fila.Rnd_tipo_operacion == 0) ? "" : fila.Rnd_tipo_operacion.ToString(),
                    fila.Tipo_trabajo.ToString(),
                    (fila.Tiempo_trabjo == 0) ? "" : fila.Tiempo_trabjo.ToString(),
                    (fila.Rnd_duracion == 0) ? "" : fila.Rnd_duracion.ToString(),
                    (fila.Duracion == 0) ? "" : fila.Duracion.ToString(),
                    (fila.Fin_formateo_inicial == 0) ? "" : fila.Fin_formateo_inicial.ToString("N4"),
                    (fila.Fin_atencion == 0) ? "" : fila.Fin_atencion.ToString("N4"),
                    fila.Estado_tecnico,
                    fila.Cola_tecnico,
                    fila.Cola_formateo_esperando_tecnico,
                    "", "", "", "", "", "", "", "", "", "",
                    fila.Cont_PC_atendidas,
                    fila.Cont_PC_NO_atendidas,
                    fila.Acum_permanecia.ToString("N4"),
                    fila.Promedio_permanencia_equipo.ToString("N4"),
                    fila.Promedio_PC_NO_atendidas
            );

            int indice_fila_nueva = dataGridView1.Rows.Count - 1;

            for (int i = 0; i < fila.Tiempo_puesto.Count; i++)
            {
                string nombreColumnaPuesto = "cPuesto" + (i + 1);
                dataGridView1[nombreColumnaPuesto, indice_fila_nueva].Value = (fila.Tiempo_puesto[i] == 0) ? "" : fila.Tiempo_puesto[i].ToString("N4");
            }


            agregarComputadoras();
        }

        private void agregarComputadoras()
        {
            String nombreColumna = "cComputadora";
            String cabeceraColumna = "Computadora ";

            foreach (Cliente item in fila_actual.Pcs)
            {
                //Obtenemos el indice de la ultima fila agregada
                int indexRow = dataGridView1.Rows.Count - 1;

                String nombreColumnaConNumero = nombreColumna + item.Nro;


                //Controlamos si la columna existe en la tabla
                if (dataGridView1.Columns.Contains(nombreColumnaConNumero) == false)
                {
                    //No existe la columna, es decir, la computadora recien ingresa

                    //Agregamos la nueva columna con el nombre de la columna y la cabecera
                    dataGridView1.Columns.Add(nombreColumnaConNumero, cabeceraColumna + item.Nro);
                }


                //Actualizamos el valor de la celda
                dataGridView1[nombreColumnaConNumero, indexRow].Value = item.Estado + "/" + item.TiempoIngreso;
            }
        }

        private void dgvTablaProbabilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ingresarProbabilidades(e);
        }
        public static void ingresarProbabilidades(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.') //Permitir punto decimal
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}