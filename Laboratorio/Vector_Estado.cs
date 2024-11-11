using Biblioteca;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace Biblioteca
{
    class Vector_Estado
    {

        private int nro_fila;
        private String evento;
        private Double reloj;
        private Double tiempoProximaLlegadaCliente;
        private Double rndSolicitudCliente;
        private String solicitudCliente;
        private Double rndConsulta;
        private Double tiempoConsulta;
        private Double tiempoFinConsulta;
        private Double rndBusquedaLibro;
        private Double tiempoBusquedaLibro;
        private Double tiempoFinBusquedaLibro;
        private Double rndDevolucionLibro;
        private Double tiempoDevolucionLibro;
        private Double tiempoFinDevolucionLibro;
        private Double rndUsoInstalacion;
        private String usoInstalacion;
        private Double tiempoFinUsoInstalacion;
        private long cantidadClientesDentro;
        private List<Empleado> empleadoList;
        private long clientesQueIngresaron;
        private long cantidadColaBusquedaLibro;
        private long cantidadColaDevolucionLibro;
        private long cantidadColaConsultaAfiliacion;



        private List<Cliente> personas;

        public int Nro_fila { get => nro_fila; set => nro_fila = value; }
        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double TiempoProximaLlegadaCliente { get => tiempoProximaLlegadaCliente; set => tiempoProximaLlegadaCliente = value; }
        public double RndSolicitudCliente { get => rndSolicitudCliente; set => rndSolicitudCliente = value; }
        public string SolicitudCliente { get => solicitudCliente; set => solicitudCliente = value; }
        public double RndConsulta { get => rndConsulta; set => rndConsulta = value; }
        public double TiempoConsulta { get => tiempoConsulta; set => tiempoConsulta = value; }
        public double TiempoFinConsulta { get => tiempoFinConsulta; set => tiempoFinConsulta = value; }
        public double RndBusquedaLibro { get => rndBusquedaLibro; set => rndBusquedaLibro = value; }
        public double TiempoBusquedaLibro { get => tiempoBusquedaLibro; set => tiempoBusquedaLibro = value; }
        public double TiempoFinBusquedaLibro { get => tiempoFinBusquedaLibro; set => tiempoFinBusquedaLibro = value; }
        public double RndDevolucionLibro { get => rndDevolucionLibro; set => rndDevolucionLibro = value; }
        public double TiempoDevolucionLibro { get => tiempoDevolucionLibro; set => tiempoDevolucionLibro = value; }
        public double TiempoFinDevolucionLibro { get => tiempoFinDevolucionLibro; set => tiempoFinDevolucionLibro = value; }
        public double RndUsoInstalacion { get => rndUsoInstalacion; set => rndUsoInstalacion = value; }
        public string UsoInstalacion { get => usoInstalacion; set => usoInstalacion = value; }
        public double TiempoFinUsoInstalacion { get => tiempoFinUsoInstalacion; set => tiempoFinUsoInstalacion = value; }
        public long CantidadClientesDentro { get => cantidadClientesDentro; set => cantidadClientesDentro = value; }
        public long ClientesQueIngresaron { get => clientesQueIngresaron; set => clientesQueIngresaron = value; }
        public long CantidadColaBusquedaLibro { get => cantidadColaBusquedaLibro; set => cantidadColaBusquedaLibro = value; }
        public long CantidadColaDevolucionLibro { get => cantidadColaDevolucionLibro; set => cantidadColaDevolucionLibro = value; }
        public long CantidadColaConsultaAfiliacion { get => cantidadColaConsultaAfiliacion; set => cantidadColaConsultaAfiliacion = value; }
        internal List<Empleado> EmpleadoList { get => empleadoList; set => empleadoList = value; }

        public Vector_Estado()
        {
            evento = "INICIO";
            reloj = 0;
            tiempoProximaLlegadaCliente = 0;
            solicitudCliente = "";

            this.empleadoList = new List<Empleado>();
            this.empleadoList.Add(new Empleado());
            this.empleadoList.Add(new Empleado());

            this.clientesQueIngresaron = 0;
            this.cantidadColaBusquedaLibro = 0;
            this.cantidadColaDevolucionLibro = 0;
            this.cantidadColaConsultaAfiliacion = 0;
        }



        internal void evento_inicio(Double tiempoEntreLlegadas)
        {
            this.evento = EventoBiblioteca.INICIO;
            this.reloj = 0;

            //Como es el primer evento, generamos la proxima llegada de la computadora
            
            this.tiempoProximaLlegadaCliente = reloj + tiempoEntreLlegadas;

        }



        internal void evento_proxima_llegada_computadora(List<TablaProbabilidad> tablaProbabilidads, Double tiempo_amplitud_A, Double tiempo_amplitud_B, Double tiempo_formateo_inicial, Double tiempo_final)
        {
            this.personas_ingresadas++;

            this.evento = EventoBiblioteca.LLEGADA_CLIENTE + " " + this.personas_ingresadas;
            this.reloj = this.Tiempo_llegada;

            //Calculamos la proxima llegada
            this.rnd_llegada = GeneradoresRND.RndLenguaje();
            //ponemos los valoes de 30 y 90 que no pedían ser parametizables
            this.tiempo_entre_llegada = GeneradoresRND.uniforme(30, 90, this.rnd_llegada);
            this.tiempo_proxima_llegada = this.reloj + this.tiempo_entre_llegada;


            //Creamos una nueva computadora, con estado EA por defecto
              nueva_pc = new PC(this.personas_ingresadas, this.reloj);

            //Si esta ocupado
            if (this.estado_tecnico == EstadoEmpleado.OCUPADO)
            {
                // y tiene espacio en la cola, va a la cola
                if (this.cola_tecnico < 3)
                {
                    //Incrementamos la cola del tecnico
                    this.cola_tecnico++;

                    //Reseteamos los valores ya que no son utilizados en el evento.
                    this.rnd_tipo_operacion = 0;
                    this.tipo_operacion = "";
                    this.tiempo_trabajo = 0;
                    this.rnd_duracion = 0;
                    this.duracion = 0;

                    //Guardamos la nueva computadora
                    this.personas.Add(nueva_pc);
                }
                else //Tenemos mas de 3 computadoras, por lo tanto, no se atiende
                {
                    this.cont_PC_NO_atendidas++;
                }
            }
            //Esta libre y por lo tanto, puede atender
            else
            {
                //Calculamos el tipo de operacion que es
                calcular_tipo_operacion(tablaProbabilidads);

                //Si es "Formateo de Disco" se calcula
                //- Fin Formateo Inicial
                //- Fin Formateo Sola
                if (this.tipo_operacion == TipoOperacion.FORMATEO_DISCO)
                {
                    //Buscamos si existe algun puesto libre
                    int puesto_libre = buscar_puesto_libre();

                    if (puesto_libre >= 0)
                    { 
                        //Si existe un puesto libre:
                        //Calculamos el tiempo fin de formateo inicio
                        this.fin_formateo_inicial = this.reloj + tiempo_formateo_inicial ;

                        //Calculamos la duración final del operacion a realizar
                        calcular_duracion(tiempo_amplitud_A, tiempo_amplitud_B);

                        //Calculamos el tiempo fin de formateo sola
                        Double fin_formateo_sin_tec = this.fin_formateo_inicial + this.duracion - tiempo_final - tiempo_formateo_inicial;

                        //Guardamos el tiempo que comenzo el formateo inicial, es decir, el tiempo del reloj
                        this.tiempo_puesto[puesto_libre] = fin_formateo_sin_tec;

                        //Cambiamos el estado de la nueva Computadora
                        nueva_pc.Estado = EstadoCliente.FORMATEO_INICIAL;

                        //Actualizamos el estado del Tecnico a Ocupado
                        this.estado_tecnico = EstadoEmpleado.OCUPADO;

                        //Guardamos la nueva computadora
                        this.personas.Add(nueva_pc);
                    }
                    else
                    {
                        //Actualizamos el estado del Tecnico a Libre ya que no la va a atender
                        this.estado_tecnico = EstadoEmpleado.LIBRE;

                        //No tenemos puesto libre, por ende, lo descartamos
                        this.cont_PC_NO_atendidas++;
                    }
                }
                //En el caso que no lo sea
                else
                {
                    //Calculamos la duración final del operacion a realizar
                    calcular_duracion(tiempo_amplitud_A, tiempo_amplitud_B);

                    //El fin de atencion será la duración del operacion
                    this.fin_atencion = this.reloj + this.duracion;

                    //Actualizamos el estado de la nueva Computadora
                    nueva_pc.Estado = EstadoCliente.SIENDO_ATENDIDA;

                    //Actualizamos el estado del Tecnico a Ocupado
                    this.estado_tecnico = EstadoEmpleado.OCUPADO;

                    //Guardamos la nueva computadora
                    this.personas.Add(nueva_pc);
                }
            }
        }

        private void calcular_duracion(double tiempo_amplitud_A, double tiempo_amplitud_B)
        {
            this.rnd_duracion = GeneradoresRND.RndLenguaje();
            this.duracion = this.tiempo_trabajo + GeneradoresRND.uniforme(tiempo_amplitud_A, tiempo_amplitud_B, this.rnd_duracion);
        }

        private void calcular_tipo_operacion(List<TablaProbabilidad> tablaProbabilidads)
        {
            this.rnd_tipo_operacion = GeneradoresRND.RndLenguaje();
            //this.rnd_tipo_operacion = 0.6; //TODO: modificar

            //Buscamos el tipo y tiempo de operacion
            foreach (TablaProbabilidad item in tablaProbabilidads)
            {
                if(this.rnd_tipo_operacion < item.Pr_acum)
                {
                    this.tipo_operacion = item.NombreOperacion;
                    // no se calcula una duracion asi que esto no va this.tiempo_trabajo = item.Duracion;

                    //Luego de encontrar el operacion, finaliza la ejecución del ciclo
                    break;
                }
            }
        }

        internal void evento_fin_formateo_inicial(List<TablaProbabilidad> tablaProbabilidads, Double tiempo_amplitud_A, Double tiempo_amplitud_B, Double tiempo_formateo_inicial, Double tiempo_final)
        {
            PC computadora_fin_formateo_inicial = personas.First(c => c.Estado == EstadoCliente.FORMATEO_INICIAL);

            this.evento = EventoBiblioteca.FIN_FORMATEO_INICIAL + " " + computadora_fin_formateo_inicial.Nro;
            this.reloj = this.fin_formateo_inicial;

            //Como termino el formateo inicial, pasa a formatear sola
            personas.First(c => c.Nro == computadora_fin_formateo_inicial.Nro).Estado = EstadoCliente.FORMATEANDO_SOLA;

            this.rnd_tipo_operacion = 0;
            this.tipo_operacion = "";
            this.fin_formateo_inicial = 0;
            this.tiempo_trabajo = 0;
            this.rnd_duracion = 0;
            this.duracion = 0;

            this.estado_tecnico = EstadoEmpleado.LIBRE;


            if (cola_formateo_esperando_tecnico > 0)
            {
                //Si tenemos computadoras para finalizar su formateo, la atiende
                this.fin_atencion = this.reloj + tiempo_final;

                //Actualizamos el estado del la computadora
                this.personas.First(c => c.Estado == EstadoCliente.ESPERANDO_FORMATEO_FINAL).Estado = EstadoCliente.SIENDO_ATENDIDA;

                //Actualizamos el estado del tecnico
                this.estado_tecnico = EstadoEmpleado.OCUPADO;

                //Actualizamos la cola de computadoras esperando finalizar su formateo
                cola_formateo_esperando_tecnico--;
            }
            else
            {
                //No tenemos computadora para terminar su formateo, por lo tanto, miro la otra cola
                if(cola_tecnico > 0)
                {
                    //Tenemos computadoras para atender

                    //Buscamos la computadora que espera ser atendida
                    PC computadora_esperando_ser_atendida = this.personas.First(c => c.Estado == EstadoCliente.ESPERANDO_ATENCION);

                    //Calculamos el tipo de operacion que es
                    calcular_tipo_operacion(tablaProbabilidads);

                    //Si es "Formateo de Disco" se calcula
                    //- Fin Formateo Inicial
                    //- Fin Formateo Sola
                    if (this.tipo_operacion == TipoOperacion.FORMATEO_DISCO)
                    {
                        //Buscamos si existe algun puesto libre
                        int puesto_libre = buscar_puesto_libre();

                        if (puesto_libre >= 0)
                        {
                            //Si existe un puesto libre:
                            //Calculamos el tiempo fin de formateo inicio
                            this.fin_formateo_inicial = this.reloj + tiempo_formateo_inicial;

                            //Calculamos la duración final del operacion a realizar
                            calcular_duracion(tiempo_amplitud_A, tiempo_amplitud_B);

                            //Calculamos el tiempo fin de formateo sola
                            Double fin_formateo_sin_tec = this.fin_formateo_inicial + this.duracion - tiempo_final - tiempo_formateo_inicial;

                            //Guardamos el tiempo que comenzo el formateo inicial, es decir, el tiempo del reloj
                            this.tiempo_puesto[puesto_libre] = fin_formateo_sin_tec;

                            //Cambiamos el estado de la Computadora
                            this.personas.First(c => c.Nro == computadora_esperando_ser_atendida.Nro).Estado = EstadoCliente.FORMATEO_INICIAL;

                            //Actualizamos el estado del Tecnico a Ocupado
                            this.estado_tecnico = EstadoEmpleado.OCUPADO;
                        }
                        else
                        {
                            //Actualizamos el estado del Tecnico a Libre ya que no la va a atender
                            this.estado_tecnico = EstadoEmpleado.LIBRE;

                            //No tenemos puesto libre, por ende, lo descartamos
                            this.cont_PC_NO_atendidas++;
                        }
                    }
                    //En el caso que no lo sea
                    else
                    {
                        //Calculamos la duración final del operacion a realizar
                        calcular_duracion(tiempo_amplitud_A, tiempo_amplitud_B);

                        //El fin de atencion será la duración del operacion
                        this.fin_atencion = this.reloj + this.duracion;

                        //Cambiamos el estado de la Computadora
                        this.personas.First(c => c.Nro == computadora_esperando_ser_atendida.Nro).Estado = EstadoCliente.SIENDO_ATENDIDA;

                        //Actualizamos el estado del Tecnico a Ocupado
                        this.estado_tecnico = EstadoEmpleado.OCUPADO;
                    }

                    //Actualizamos la cola del tecnico
                    this.cola_tecnico--;
                }
            } 
        }

        private int buscar_puesto_libre()
        {
            for (int i = 0; i < this.tiempo_puesto.Count; i++)
            {
                if (this.tiempo_puesto[i] <= 0)
                {
                    //Encontro un puesto libre, ya que su tiempo es menor o igual a cero.
                    return i;
                }
            } 

            //En caso que no tenga ningún puesto libre, retorna -1
            return -1;
        }

        internal void evento_fin_formateo_sin_tecnico(List<TablaProbabilidad> tablaProbabilidads, Double tiempo_amplitud_A, Double tiempo_amplitud_B, Double tiempo_final)
        {
            int nro_puesto = 0;

            double tiempo_min = Double.MaxValue;

            for (int i = 0; i < this.tiempo_puesto.Count; i++)
            {
                if (this.tiempo_puesto[i] > 0 && this.tiempo_puesto[i] < tiempo_min)
                {
                    tiempo_min = this.tiempo_puesto[i];
                    nro_puesto = i + 1;
                }
            }

            PC computadora_fin_formateo_sola = this.personas.First(c => c.Estado == EstadoCliente.FORMATEANDO_SOLA);

            this.evento = EventoBiblioteca.FIN_ATENCION_DEVOLUCION + " " + computadora_fin_formateo_sola.Nro + " Puesto " + nro_puesto;
            this.reloj = tiempo_min;


            //Actualizamos el tiempo del puesto
            this.tiempo_puesto[nro_puesto - 1] = 0;

            
            if(this.estado_tecnico == EstadoEmpleado.LIBRE)
            {
                //Si esta libre, toma la computadora que finalizo su formateo sola
                this.fin_atencion = this.reloj + tiempo_final;

                //Actualizamos el estado del la computadora
                this.personas.First(c => c.Nro == computadora_fin_formateo_sola.Nro).Estado = EstadoCliente.SIENDO_ATENDIDA;

                //Actualizamos el estado del tecnico
                this.estado_tecnico = EstadoEmpleado.OCUPADO;
            }
            else
            {
                //El tecnico se encuentra ocupado, por lo tanto, pasa a esperar para terminar el formateo
                this.personas.First(c => c.Nro == computadora_fin_formateo_sola.Nro).Estado = EstadoCliente.ESPERANDO_FORMATEO_FINAL;

                //Aumentamos la cola de computadoras que esperan finalizar su formateo con el tecnico
                this.cola_formateo_esperando_tecnico++;
            }


            this.rnd_llegada = 0;
            this.tiempo_entre_llegada = 0;
            this.rnd_tipo_operacion = 0;
            this.tipo_operacion = "";
            this.rnd_duracion = 0;
            this.duracion = 0;
            this.tiempo_trabajo = 0;
        }

        internal void evento_fin_atencion(List<TablaProbabilidad> tablaProbabilidads, Double tiempo_amplitud_A, Double tiempo_amplitud_B, Double tiempo_formateo_inicial, Double tiempo_final)
        {
            //Buscamos la Computadora que está esta siendo atendida, es decir, que se va del sistema
            PC pc_finalizando = personas.First(c => c.Estado == EstadoCliente.SIENDO_ATENDIDA);

            this.evento = EventoBiblioteca.FIN_LECTURA + " " + pc_finalizando.Nro;
            this.reloj = this.fin_atencion;

            //Incrementamos el contador de computadoras atendidas
            this.cont_PC_atendidas++;

            //Acumulamos el tiempo de permanencia en el sistema
            this.acum_permanecia = this.acum_permanecia + (this.reloj - pc_finalizando.Tiempo_ingreso);

            //Removemos la Computadora del sistema
            personas.Remove(pc_finalizando);

            this.rnd_llegada = 0;
            this.tiempo_entre_llegada = 0;
            this.rnd_tipo_operacion = 0;
            this.tipo_operacion = "";
            this.rnd_duracion = 0;
            this.duracion = 0;
            this.tiempo_trabajo = 0;
            //this.fin_formateo_inicial = 0;
            this.fin_atencion = 0;

            this.estado_tecnico = EstadoEmpleado.LIBRE;


            if (cola_formateo_esperando_tecnico > 0)
            {
                //Si tenemos computadoras para finalizar su formateo, la atiende
                this.fin_atencion = this.reloj + tiempo_final;

                //Actualizamos el estado del la computadora
                this.personas.First(c => c.Estado == EstadoCliente.ESPERANDO_FORMATEO_FINAL).Estado = EstadoCliente.SIENDO_ATENDIDA;

                //Actualizamos el estado del tecnico
                this.estado_tecnico = EstadoEmpleado.OCUPADO;

                //Actualizamos la cola de computadoras esperando finalizar su formateo
                cola_formateo_esperando_tecnico--;
            }
            else
            {
                //No tenemos computadora para terminar su formateo, por lo tanto, miro la otra cola
                if (cola_tecnico > 0)
                {
                    //Tenemos computadoras para atender

                    //Buscamos la computadora que espera ser atendida
                    PC computadora_esperando_ser_atendida = this.personas.First(c => c.Estado == EstadoCliente.ESPERANDO_ATENCION);

                    //Calculamos el tipo de operacion que es
                    calcular_tipo_operacion(tablaProbabilidads);

                    //Si es "Formateo de Disco" se calcula
                    //- Fin Formateo Inicial
                    //- Fin Formateo Sola
                    if (this.tipo_operacion == TipoOperacion.FORMATEO_DISCO)
                    {
                        //Buscamos si existe algun puesto libre
                        int puesto_libre = buscar_puesto_libre();

                        if (puesto_libre >= 0)
                        {
                            //Si existe un puesto libre:
                            //Calculamos el tiempo fin de formateo inicio
                            this.fin_formateo_inicial = this.reloj + tiempo_formateo_inicial;

                            //Calculamos la duración final del operacion a realizar
                            calcular_duracion(tiempo_amplitud_A, tiempo_amplitud_B);

                            //Calculamos el tiempo fin de formateo sola
                            Double fin_formateo_sin_tec = this.fin_formateo_inicial + this.duracion - tiempo_final - tiempo_formateo_inicial;

                            //Guardamos el tiempo que comenzo el formateo inicial, es decir, el tiempo del reloj
                            this.tiempo_puesto[puesto_libre] = fin_formateo_sin_tec;

                            //Cambiamos el estado de la Computadora
                            this.personas.First(c => c.Nro == computadora_esperando_ser_atendida.Nro).Estado = EstadoCliente.FORMATEO_INICIAL;

                            //Actualizamos el estado del Tecnico a Ocupado
                            this.estado_tecnico = EstadoEmpleado.OCUPADO;
                        }
                        else
                        {
                            //Actualizamos el estado del Tecnico a Libre ya que no la va a atender
                            this.estado_tecnico = EstadoEmpleado.LIBRE;

                            //No tenemos puesto libre, por ende, lo descartamos
                            this.cont_PC_NO_atendidas++;
                        }
                    }
                    //En el caso que no lo sea
                    else
                    {
                        //Calculamos la duración final del operacion a realizar
                        calcular_duracion(tiempo_amplitud_A, tiempo_amplitud_B);

                        //El fin de atencion será la duración del operacion
                        this.fin_atencion = this.reloj + this.duracion;

                        //Cambiamos el estado de la Computadora
                        this.personas.First(c => c.Nro == computadora_esperando_ser_atendida.Nro).Estado = EstadoCliente.SIENDO_ATENDIDA;

                        //Actualizamos el estado del Tecnico a Ocupado
                        this.estado_tecnico = EstadoEmpleado.OCUPADO;
                    }

                    //Actualizamos la cola del tecnico
                    this.cola_tecnico--;
                }
            }
        }

        internal void calcular_tiempo_promedio_permanencia()
        {
            //Controlamos si ya se atendieron computadoras
            //Ya que el denominador si es 0, da error
            if(this.cont_PC_atendidas > 0)
            {
                //Lo convertimos en Double ya que en C# si se divide por un entero, el resultado es entero.
                this.promedio_permanencia_equipo = this.acum_permanecia / Convert.ToDouble(this.cont_PC_atendidas);
            }
        }

        internal void calcular_porcentaje_equipos_no_atendidos()
        {
            //Si alguno de los dos no es cero, recien podemos calcular el promedio
            //ya que si ambos son igual a cero, da un error matematico en el denominador.
            if(this.Cont_PC_NO_atendidas > 0 || this.cont_PC_atendidas > 0)
            {
                //Lo convertimos en Double ya que en C# si se divide por un entero, el resultado es entero.
                this.promedio_PC_NO_atendidas = this.Cont_PC_NO_atendidas / Convert.ToDouble(this.Cont_PC_NO_atendidas + this.cont_PC_atendidas);
            }
        } 
    } 
}
