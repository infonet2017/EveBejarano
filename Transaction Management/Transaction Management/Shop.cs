using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Shop
    {
        List<Debt> Debts { get; set;}
        List<Loan> Loans { get; set; }
        List<Client> Clients { get; set; }
        List<Provider> Providers { get; set; }

        List<Product> ListOfProducts { get; set; }

        public Shop()
        {
            ListOfProducts = new List<Product>();
            Clients = new List<Client>();
            Loans = new List<Loan>();
            Debts = new List<Debt>();
            Providers = new List<Provider>();

        }


        //VERIFICA LA EXISTENCIA DE UN PRODUCTO

        public Boolean IsExistProduct(int Producto)
        {
            var resultado = ListOfProducts.Find(p => p.Code == Producto);

            if (resultado == null)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        //BUSCA UN PRODUCTO POR SU CODIGO Y LO RETORNA

        public Product GetProduct(int code)
        {
            var resultado = ListOfProducts.Find(p => p.Code == code);

            return (resultado);

        }

        // CREA Y AGREGA UN PRODUCTO  AL INVENTARIO
        public Product AddNewProduct(int Code, string Name, float Price, int Amount)
        {
            Product producto = new Product();
            producto.Code = Code;
            producto.Name = Name;
            producto.Price = Price;
            producto.Amount = Amount;
            ListOfProducts.Add(producto);
            return producto;
        }


        // DEVUELVE UN LISTADO DE PRODUCTOS

        public string GetAllProducts()
        {

            var text = "";

            foreach (var product in ListOfProducts)
            {

                text = $"{text}Nombre:{product.Name}; Precio:{product.Price} Cantidad:{product.Amount}\n";
            }

            return text;
        }




        // CREA UN NUEVO PRÉSTAMO Y LO AGREGA A LA LISTA DE LAS MISMAS

        public void AddNewLoan(Sale NewSale, float Monto)
        {
            Loan Loan = new Loan();
            Loan.InFavorSale = NewSale;
            Loan.Amount = Monto;
            Loans.Add(Loan);
        }

        // DEVUELVE UN LISTADO DE PRÉSTAMOS

        public string GetAllLoans()
        {
            var text = "";

            foreach (var loan in Loans)
            {
                text = $"{text}Fecha:{loan.Date}; DNI: {loan.InFavorSale.Client.DNI}; Cliente: {loan.InFavorSale.Client.Name}; Monto: {loan.Amount} \n";
            }

            return text;
        }

        // CREA UNA NUEVA DEUDA Y LO AGREGA A LA LISTA DE LAS MISMAS
        public void AddNewDebt(Purchase NewPurchase, float Amount)
        {
            Debt Debt = new Debt();
            Debt.Amount = Amount;
            Debt.OwedPurchase = NewPurchase;
            Debts.Add(Debt);
        }

        // DEVUELVE UN LISTADO DE DEUDAS
        public string GetAllDebts()
        {
            var text = "";

            foreach (var debt in Debts)
            {
                text = $"{text}Fecha:{debt.Date}; DNI: {debt.OwedPurchase.Provider.DNI};Proveedor: {debt.OwedPurchase.Provider.Name}; Monto: {debt.Amount} \n";
            }

            return text;
        }





        // VERIFICA LA EXISTENCIA DE UN CLIENTE
        public Boolean IsExistClient(int dni)
        {
            var resultado = Clients.Find(p => p.DNI == dni);

            if (resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //BUSCA UN CLIENTE POR SU DNI Y LO RETORNA
        public Client GetClient(int dni)
        {
            var resultado = Clients.Find(p => p.DNI == dni);

            return (resultado);

        }


        // CREA UN NUEVO CLIENTE Y LO AGREGA A LA LISTA DE CLIENTES

        public Client AddNewClient(int dni, string name, int cellphone, string adress)
        {
            Client NewClient = new Client();
            NewClient.DNI = dni;
            NewClient.Name = name;
            NewClient.Cellphone = cellphone;
            NewClient.Adress = adress;
            Clients.Add(NewClient);
            return (NewClient);
        }




        // VERIFICA LA EXISTENCIA DE UN PROVEEDOR

        public Boolean IsExistProvider(int dni)
        {
            var resultado = Providers.Find(p => p.DNI == dni);

            if (resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //BUSCA UN PROVEEDOR POR SU DNI Y LO RETORNA

        public Provider GetProvider(int dni)
        {
            var resultado = Providers.Find(p => p.DNI == dni);

            return (resultado);

        }

        // CREA UN NUEVO PROVEEDOR Y LO AGREGA A LA LISTA DE PROVEEDORES

        public Provider AddNewProvider(int dni, string name, int cellphone, string adress)
        {
            Provider NewProvider = new Provider();
            NewProvider.DNI = dni;
            NewProvider.Name = name;
            NewProvider.Cellphone = cellphone;
            NewProvider.Adress = adress;
            Providers.Add(NewProvider);
            return (NewProvider);
        }
    }
}
