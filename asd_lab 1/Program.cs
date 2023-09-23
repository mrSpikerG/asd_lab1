//Видати на екран список дітей в алфавітному порядку імен
int choose =-1;
Kid[] arr = new Kid[3] {

    new Kid{Name="Vasya",Gender="Femboy",Group="31-4-Z" },
    new Kid{Name="Petya",Gender="Men",Group="DE-99-3" },
    new Kid{Name="Misha",Gender="Girl",Group="Cf-05-4" }
};

do {
    try {
        Console.WriteLine("\tMenu");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - List");
        Console.WriteLine("3 - Ordered List");
        choose = int.Parse(Console.ReadLine());

        if (choose == 1) {
            Console.Write("Input name: ");
            string name = Console.ReadLine();
            Console.Write("Input gender: ");
            string gender = Console.ReadLine();
            Console.Write("Input group: ");
            string group = Console.ReadLine();

            Kid temp = new Kid(name, gender, group);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = temp;
        }

        if (choose == 2) {
            for (int i = 0; i < arr.Length; i++) {vvvvvvvvvvvvvvvvvvv
                Console.WriteLine(arr[i]);
            }
        }
        if (choose == 3) {

            var temp = arr.OrderBy(x => x.Name).ToArray();


            for (int i = 0; i < temp.Length; i++) {
                Console.WriteLine(temp[i]);
            }
        }
    }
    catch(Exception ex) {
        Console.WriteLine("Unexpected exception");
    }

} while (choose != 0);



struct Kid {

    public string Name;
    public string Gender;
    public string Group;
    public Kid(string name, string gender, string group) {
        this.Name = name;
        this.Gender = gender;
        this.Group = group;
    }

    public override string ToString() {
        return $"{this.Name} {this.Gender} [{this.Group}]";
    }
}

