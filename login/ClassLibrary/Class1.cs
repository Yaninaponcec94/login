using System;

namespace Entidades
{
    public enum EPosicion
    {
        Arquero,
        Defensor,
        Mediocampista,
        Delantero
    }

    public class Jugador 
    {
        private static int ultimoId;

        private int id;
        private string nombre;
        private EPosicion posicion;
        private int numero;
        private int edad;
        private string nacionalidad;
        private bool estaLesionado; //los inicializo por defecto en false en el ctor
        private bool estaSuspendido;


        static Jugador()
        {
            ultimoId = 1;
            
        }


        public Jugador(string nombre, EPosicion posicion, int numero, int edad, string nacionalidad)
        {
            this.id = ultimoId;
            this.nombre = nombre;
            this.posicion = posicion;
            this.numero = numero;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
            this.estaLesionado = false; 
            this.estaSuspendido = false;

            // entonces cada vez q yo pase por el ctor e inicialice un objeto
            ultimoId++;  
            // es un contador que sabe cuantos jugadores se construyeron
        }
        //hacer esto: 
        public string getNacionalidad // ASI TRATA DE NO
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        //es LO MISMO QUE PONER PUBLIC EN VEZ DE PRIVATE los atributos! no esta mal, esta permitido pero tengo que tener en cuenta que si utilizo las propiedades tienen que tener un sentido de uso

        //las propiedades no llevan () -> diferencia con los metodos
        //no se puede parametrizar (en general los param van entre () )
        //aca por lo menos estoy validando el uso!
        public string Nombre   // ASI SI!! (estoy VALIDANDO)
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                else
                {
                    nombre = "sin nombre";
                }
                    
            }
        }

        //las PROPERTY definen el estado (mediante o no el uso de los atributos) y los métodos definen las acciones que realiza el objeto con esos atributos.
        public string estadoJugador
        {
            get
            {
                if (this.estaLesionado)
                    return "Se lastimo";
                else if (this.estaSuspendido)
                    return "esta suspendido";
                else
                    return "jugador apto para jugar";
            }
        }

        //una property NO es un método! los métodos dejan hacer.
        //la propiedad ENCAPSULA con -> GET
        //si quiero manipular la informacion -> SET

        
    }
}