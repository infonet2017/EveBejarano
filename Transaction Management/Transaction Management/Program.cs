using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop ActualShop = new Shop();

            int Opcion;

            Console.WriteLine("Ingrese el numero correspondiente a lo que desea hacer:");
            Console.WriteLine("Ingrese 0 si desea salir del Programa");
            Console.WriteLine("Ingrese 1 si desea registrar una nueva compra de productosa un proveedor");
            Console.WriteLine("Ingrese 2 si desea registrar una nueva venta de productos a un cliente");
            Console.WriteLine("Ingrese 3 si desea listar sus deudas con proveedores");
            Console.WriteLine("Ingrese 4 si desea listar sus prestamos a clientes");
            Console.WriteLine("Ingrese 5 si desea listar sus productos en el inventario");
            int.TryParse(Console.ReadLine(), out Opcion);

            while (Opcion != 0 && Opcion <6)
            {
               
                switch (Opcion)
                {
                    case 1:

                        //Instancia una nueva compra

                        Purchase NewPurchase = new Purchase();

                        NewPurchase.PurchasedProducts = new List<Product>();

                        // Pide la fecha de la compra

                        Console.WriteLine("Ingrese día:");
                        int.TryParse(Console.ReadLine(), out var dia);
                        Console.WriteLine("Ingrese mes:");
                        int.TryParse(Console.ReadLine(), out var mes);
                        Console.WriteLine("Ingrese año:");
                        int.TryParse(Console.ReadLine(), out var año);
                        Console.WriteLine("Ingrese hora:");
                        int.TryParse(Console.ReadLine(), out var hora);
                        Console.WriteLine("Ingrese minutos:");
                        int.TryParse(Console.ReadLine(), out var minutos);

                        string dateTime = dia +"/"+ mes + "/" + año +" "+ hora + ":" + minutos +":00.00";
                        NewPurchase.Date = Convert.ToDateTime(dateTime);

                        //Busca el proveedor por el DNI, sino existe lo crea

                        Console.WriteLine("Ingrese DNI del Proveedor:");
                        int.TryParse(Console.ReadLine(), out var dni);

                        if (ActualShop.IsExistProvider(dni) == true)
                        {
                            NewPurchase.Provider = ActualShop.GetProvider(dni);
                        }
                        else
                        {
                            Console.WriteLine("Ingrese Nombre:");
                            var name = Console.ReadLine();
                            Console.WriteLine("Ingrese N° de Celular:");
                            int.TryParse(Console.ReadLine(), out var cellphone);
                            Console.WriteLine("Ingrese Dirección:");
                            var adress = Console.ReadLine();

                            NewPurchase.Provider = ActualShop.AddNewProvider(dni, name, cellphone, adress);
                        }


                        // CARGA LA LISTA DE PRODUCTOS A COMPRAR Y CALCULA EL TOTAL A PAGAR

                        Console.WriteLine("Ingrese el codigo del producto a comprar");
                        Console.WriteLine("o 0 si no desea agregar mas productos");

                        int.TryParse(Console.ReadLine(), out Opcion);
                        float Total = 0;

                        while (Opcion != 0)
                        {

                            // PIDE LA CANTIDAD A COMPRAR, SI LA CANTIDAD ES VALIDA, BUSCA EL PRODUCTO Y SI NO EXISTE LO CREA.

                            Console.WriteLine("Ingrese la cantidad del producto a comprar");
                            int.TryParse(Console.ReadLine(), out int Cant);

                            if (Cant > 0)
                            {
                                Product Product;


                                if (ActualShop.IsExistProduct(Opcion) == true)
                                {
                                    Product = ActualShop.GetProduct(Opcion);
                                    Product.Amount += Cant;
                                }

                                else
                                {
                                    Console.WriteLine("Ingrese Nombre del Nuevo Producto:");
                                    var name = Console.ReadLine();

                                    Console.WriteLine("Ingrese Precio Unitario:");
                                    float.TryParse(Console.ReadLine(), out var price);

                                    Product = ActualShop.AddNewProduct(Opcion, name, price, Cant);
                                }


                                Total += Product.Price * Cant;

                                NewPurchase.PurchasedProducts.Add(Product);

                            }

                            else
                            {
                                Console.WriteLine("Error: Cantidad no válida. Vuelva a intentar");
                            }


                            // SI DESEA CARGAR OTRO PRODUCTO INGRESA SU CÓDIGO, SI INGRESA 0 O CUALQUIER VALOR NO VÁLIDO SALE


                            Console.WriteLine("Ingrese el codigo del producto a comprar");
                            Console.WriteLine("o 0 si no desea agregar mas productos");

                            int.TryParse(Console.ReadLine(), out Opcion);

                        }

                        //IMPRIME EL MONTO A PAGAR Y PIDE EL MONTO QUE EL SHOP LE VA A PAGAR AL PROVEEDOR

                        Console.WriteLine($"E monto a pagar es {Total}, Ingrese la cantidad con la que va a pagar. Si el total a pagar es mayor, se le creara una deuda con el proveedor.");
                        float.TryParse(Console.ReadLine(), out float MontoParaPagar);


                        // SI EL MONTO A PAGAR ES MAYOR QUE EL INGRESADO, SE GENERA UNA DEUDA CON EL PROVEEDOR.

                        if (Total > MontoParaPagar)
                        {

                            ActualShop.AddNewDebt(NewPurchase, Total - MontoParaPagar);

                        }


                        break;

                    case 2:

                        Sale NewSale = new Sale();
                        NewSale.SoldProducts = new List<Product>();

                        Console.WriteLine("Ingrese día:");
                        int.TryParse(Console.ReadLine(), out var dia1);
                        Console.WriteLine("Ingrese mes:");
                        int.TryParse(Console.ReadLine(), out var mes1);
                        Console.WriteLine("Ingrese año:");
                        int.TryParse(Console.ReadLine(), out var año1);
                        Console.WriteLine("Ingrese hora:");
                        int.TryParse(Console.ReadLine(), out var hora1);
                        Console.WriteLine("Ingrese minutos:");
                        int.TryParse(Console.ReadLine(), out var minutos1);

                        string dateTime1 = $"{dia1}/{mes1}/{año1} {hora1}:{minutos1}:00.00";
                        NewSale.Date = Convert.ToDateTime(dateTime1);


                        Console.WriteLine("Ingrese DNI del cliente:");
                        int.TryParse(Console.ReadLine(), out var dni1);

                        if (ActualShop.IsExistClient(dni1) == true)
                        {
                            NewSale.Client = ActualShop.GetClient(dni1);
                        }
                        else
                        {
                            Console.WriteLine("Ingrese Nombre:");
                            var name = Console.ReadLine();
                            Console.WriteLine("Ingrese N° de Celular:");
                            int.TryParse(Console.ReadLine(), out var cellphone);
                            Console.WriteLine("Ingrese Dirección:");
                            var adress = Console.ReadLine();

                            NewSale.Client = ActualShop.AddNewClient(dni1, name, cellphone, adress);
                        }


                        Console.WriteLine("Ingrese 0 si no desea agregar mas productos");
                        Console.WriteLine("Ingrese el codigo del producto a vender");
                        int.TryParse(Console.ReadLine(), out Opcion);
                        float TotalCompra = 0;



                        while (Opcion != 0)
                        {
                            Product Product;
                            if (ActualShop.IsExistProduct(Opcion) == true)
                            {
                                Product = ActualShop.GetProduct(Opcion);

                                Console.WriteLine("Ingrese la cantidad del producto a vender");
                                int.TryParse(Console.ReadLine(), out int Cant);

                                if (Product.Amount >= Cant && Cant > 0)
                                {
                                    TotalCompra += Product.Price * Cant;

                                    Product.Amount -= Cant;

                                    NewSale.SoldProducts.Add(Product);

                                }

                                else
                                {
                                    Console.WriteLine("Error: Cantidad vendida mayor a la cantidad del producto almacenado o dicha cantidad es menor a 0. Vuelva a intentar");
                                }
                            }

                            else
                            {
                                Console.WriteLine("Error: Producto NO existente");
                            }

                            Console.WriteLine("Ingrese 0 si no desea agregar mas productos");
                            Console.WriteLine("Ingrese el codigo del producto a vender");
                            int.TryParse(Console.ReadLine(), out Opcion);

                        }

                        Console.WriteLine($"El monto a pagar es {TotalCompra}, Ingrese la cantidad con la que va a pagar. Si el total a pagar es mayor, se le creara una deuda al cliente.");
                        float.TryParse(Console.ReadLine(), out float MontoAPagar);

                        if (TotalCompra > MontoAPagar)
                        {
                            ActualShop.AddNewLoan(NewSale, TotalCompra - MontoAPagar);
                        }

                        break;

                    case 3:

                        Console.WriteLine(ActualShop.GetAllDebts());
                        break;

                    case 4:
                        Console.WriteLine(ActualShop.GetAllLoans());
                        break;

                    case 5:
                        Console.WriteLine(ActualShop.GetAllProducts());
                        break;
                }

                Console.WriteLine("Ingrese el numero correspondiente a lo que desea hacer:");
                Console.WriteLine("Ingrese 0 si desea salir del Programa");
                Console.WriteLine("Ingrese 1 si desea registrar una nueva compra de productosa un proveedor");
                Console.WriteLine("Ingrese 2 si desea registrar una nueva venta de productos a un cliente");
                Console.WriteLine("Ingrese 3 si desea listar sus deudas con proveedores");
                Console.WriteLine("Ingrese 4 si desea listar sus prestamos a clientes");
                Console.WriteLine("Ingrese 5 si desea listar sus productos en el inventario");
                int.TryParse(Console.ReadLine(), out Opcion);
            }

        }
    }
}
