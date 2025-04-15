namespace practiceforobjectandclasses
{

    class Car
    {
        //methods
        public void drive()
        {
            Console.WriteLine($"Hello i am {Model} and i am of the brand {Brand} and i am driving");
        }

        


        //member variable
        private string _model;
        private string _brand;
        private bool _isluxury;
        public Car(string model, string brand , bool isluxury)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"An {model} of {brand}  has been Created:");
            Isluxury = isluxury;
        }

        //Properties in c# (Getter and Setters.) , Custom Properties
        public string Model { get => _model; set => _model = value; }
        public string Brand { get
            {
                if (Isluxury)
                {
                    return _brand + "  Luxury edition";
                }
                else
                {
                    return _brand;
                }
            } 
            set { if (string.IsNullOrEmpty(value)){
                    Console.WriteLine("You entered Nothing");
                    _brand = "Default Value";
                }
                else {
                    _brand = value;
                }
            }

            
        }
        

        public bool Isluxury { get => _isluxury; set => _isluxury = value; }

        internal class Program
        {


            static void Main(string[] args)
            {
                //Car p = new Car("I7", "Bmw", true);
                //Car p1 = new Car("I8", "Bmw", false);
                //p1.drive();
                //p.drive();



                //Console.WriteLine($"Brand is : {p.Brand}");
                //Console.WriteLine($"Brand is : {p1.Brand}");

                //Customer riya = new Customer("Riya");
                Customer Rinal = new Customer("Rinal", "Swayam", "9979865775");
                Rinal.setdetails("Riya", "Kailash Society", "986877566757");



                ////Using Default Constructor
                //Customer newcust = new Customer();


                //Console.WriteLine("Please enter new customers name:");
                //newcust.Name = Console.ReadLine();
                //Console.WriteLine($"New Customers name is {newcust.Name}");







                //Console.WriteLine("Hello World");
                Console.ReadLine();
            }
        }
    } }
