namespace zadanko3
{
    internal interface IDog<T>
    {
        string Name { get; }
        int Age { get; set; }

        string getName();
        int getAge();
        int setAge(int age);
    }
}