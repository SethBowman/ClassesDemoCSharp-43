using ClassesDemoCSharp_43;

//Instance of the Classroom class so we can use the list it holds as a property
var classroom = new Classroom();

//Instance of a class (object)

var seth =  new Person();

//Dot notation
seth.Name = "Seth";
seth.Age = 29;
seth.HairColor = "black";

//seth.Greet();
classroom.OurClass.Add(seth);

//Object initializer syntax
var mack = new Person() 
{ 
    Name = "Mack",
    Age = 24,
    HairColor = "brown"
};

//mack.Greet();
classroom.OurClass.Add(mack);

//Using a custom constructor
var cruz = new Person("Cruz", 32, "black");

//cruz.Greet();
classroom.OurClass.Add(cruz);

classroom.GetDetails();