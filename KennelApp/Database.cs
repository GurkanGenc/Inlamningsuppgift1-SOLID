//using KennelApp.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace KennelApp
//{
//    class Database
//    {
//        public static List<Customer> Customers { get; set; }
//        //public static List<Animal> Animals { get; set; }
//        //public static List<Assignment> Assignments { get; set; }

//        public Database()
//        {
//            /* add some customers */
//            Customers = new List<Customer>();

//            var andrew = new Customer() { Id = Guid.NewGuid().ToString(), Name = "Andrew" };
//            var lovisa = new Customer() { Id = Guid.NewGuid().ToString(), Name = "Lovisa" };
//            var jennie = new Customer() { Id = Guid.NewGuid().ToString(), Name = "Jennie" };
//            var william = new Customer() { Id = Guid.NewGuid().ToString(), Name = "William" };
//            var philip = new Customer() { Id = Guid.NewGuid().ToString(), Name = "Philip" };

//            Customers.Add(andrew);
//            Customers.Add(lovisa);
//            Customers.Add(jennie);
//            Customers.Add(william);
//            Customers.Add(philip);


//            /* add some animals */
//            //Animals = new List<Animal>();

//            //var nala = new Animal() { Id = Guid.NewGuid().ToString(), Name = "Nala", Age = 2 };
//            //var hubert = new Animal() { Id = Guid.NewGuid().ToString(), Name = "Hubert", Age = 5 };
//            //var chopper = new Animal() { Id = Guid.NewGuid().ToString(), Name = "Chopper", Age = 3 };
//            //var nemo = new Animal() { Id = Guid.NewGuid().ToString(), Name = "Nemo", Age = 4 };
//            //var madicken = new Animal() { Id = Guid.NewGuid().ToString(), Name = "Madicken", Age = 7 };

//            //Animals.Add(nala);
//            //Animals.Add(hubert);
//            //Animals.Add(chopper);
//            //Animals.Add(nemo);
//            //Animals.Add(madicken);


//            /* add some owners */
//            //Owner(andrew.Id, nala.Id);
//            //Owner(lovisa.Id, hubert.Id);
//            //Owner(jennie.Id, chopper.Id);
//            //Owner(william.Id, nemo.Id);
//            //Owner(philip.Id, madicken.Id);

//            //Assignments = new List<Assignment>();
//        }

//        /* create a new customer */
//        public Customer AddCustomer(string name)
//        {
//            var customer = new Customer() { Id = Guid.NewGuid().ToString(), Name = name };
//            Customers.Add(customer);

//            return customer;
//        }


//        /* get the customer by name */
//        public Customer GetCustomerByName(string name)
//        {
//            return Customers.Where(c => c.Name == name).FirstOrDefault();
//        }


//        /* get the customer by id */
//        public Customer GetCustomerById(string id)
//        {
//            return Customers.Where(c => c.Id == id).FirstOrDefault();
//        }


//        /* create a new animal */
//        //public Animal AddAnimal(string name, int age)
//        //{
//        //    var animal = new Animal() { Id = Guid.NewGuid().ToString(), Name = name, Age = age };
//        //    Animals.Add(animal);

//        //    return animal;
//        //}


//        /* get the animal by name */
//        //public Animal GetAnimalByName(string name)
//        //{
//        //    return Animals.Where(c => c.Name == name).FirstOrDefault();
//        //}


//        /* get the animal by id */
//        //public Animal GetAnimalById(string id)
//        //{
//        //    return Animals.Where(c => c.Id == id).FirstOrDefault();
//        //}
//        //public bool AnimalNameExists(string animalName)
//        //{
//        //    return GetAnimalByName(animalName) != null;
//        //}


//        /* lists all customers */
//        public List<Customer> ListCustomers()
//        {
//            return Customers;
//        }
//        /* lists all animals */
//        //public List<Animal> ListAnimals()
//        //{
//        //    return Animals;
//        //}
//        /* lists all assignments */
//        //public List<Assignment> ListAssignments()
//        //{
//        //    return Assignments;
//        //}

//        /* shows this animal who belongs to the customer */
//        //public bool Owner(string customerId, string animalId)
//        //{
//        //    var customer = Customers.Where(e => e.Id == customerId).First();
//        //    var animal = Animals.Where(e => e.Id == animalId).First();

//        //    try
//        //    {
//        //        animal.OwnedBy.Add(customerId);
//        //    }
//        //    catch (Exception)
//        //    {
//        //        return false;
//        //    }
//        //    return true;
//        //}


//        /* create a new assignment - animal check-in*/
//        //public string CheckInAnimal(string animalName, bool petWash, bool clawClipping)
//        //{
//        //    var assignmentToAdd = new Assignment();
//        //    var result = assignmentToAdd.CheckInAnimal(animalName, petWash, clawClipping);

//        //    Assignments.Add(assignmentToAdd);

//        //    return result;
//        //}


//        /* animal check-out*/
//        //public string CheckoutAnimal(string animalName, int basicsalary)
//        //{
//        //    var assignment = Assignments.Where(e => e.AnimalName == animalName).First();

//        //    return assignment.CheckOutAnimal(basicsalary);
//        //}
//    }
//}
