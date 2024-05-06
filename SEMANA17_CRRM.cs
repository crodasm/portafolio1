using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SMMN17_CRRM
{
    internal class Program
    {
        public struct medicamento
        {
            public string codigo;
            public string nombre;
            public int inventario;
            public decimal precio;

        }
        public struct cliente
        {
            public string nombre;
            public string direccion;
            public string nit;
            public string telefono;

        }
        public struct detallecompra
        {
            public string codigoMedicamento;
            public string cantidadMedicamento;
            public string preioUnitario;
            

        }
        public struct factura
        {
            public string nombre;
            public string nit;
            public DateTime fecha;
            public decimal totalFactura;
            public int cantidadProductos;
            public detallecompra[] detalleCompraFactura;

        }


        public static medicamento[] listadoMedicamentos = new medicamento[6];
        //public static cliente[] clienteActual = new cliente[];

        static void Main(string[] args)
        {
            medicamento med;
            med = new medicamento();
            med.codigo = "000";
            med.nombre = "ASPIRINA";
            med.inventario = 50;
            med.precio = 2;
            listadoMedicamentos[0] = med;

            med = new medicamento();
            med.codigo = "001";
            med.nombre = "DICLOFENACO";
            med.inventario = 45;
            med.precio = 5;
            listadoMedicamentos[1] = med;

            med = new medicamento();
            med.codigo = "002";
            med.nombre = "PASIFLORA";
            med.inventario = 12;
            med.precio = 3;
            listadoMedicamentos[2] = med;

            med = new medicamento();
            med.codigo = "003";
            med.nombre = "PARASETAMOL";
            med.inventario = 20;
            med.precio = 7;
            listadoMedicamentos[3] = med;

            med = new medicamento();
            med.codigo = "004";
            med.nombre = "SUCROL";
            med.inventario = 10;
            med.precio = 4;
            listadoMedicamentos[4] = med;

            med = new medicamento();
            med.codigo = "005";
            med.nombre = "JARABE PARA TOS";
            med.inventario = 8;
            med.precio = 12;
            listadoMedicamentos[5] = med;


            Console.ReadKey();



        }
    }
   
}
