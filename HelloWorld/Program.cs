// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadKey();
//Программа, которая допускает человека в комп по фамилии 
//и паролю (только три попытки)(counter =3)
static void Main(string[]args)
{
    bool userAvtorized; //= AutorizeUser();
    {
        userAvtorized =false;
        int counter = 0;
        while (counter < 3)
        {
           counter++;
           Console.Write("Введите логин : ");
           string Login = Console.ReadLine();
           Console.Write("Введите пароль : ");
           string passworld = console.ReadLine();

           userAvtorized = ("Админ" == Login && "000" == passworld)||
                           ("Иванова" == Login && "111" == passworld)||
                           ("Петрова" == Login && "222" == passworld)||
                           ("Сергеева" == Login && "333" == passworld);
            if (userAvtorized)
            {
                Console.WriteLine("Вы успешно авторизованы");
                break;
            }
            else
            {
                Console.WriteLine("Логин или пароль введены неверно")
            }
        }
        if (userAvtorized == false)
        {
            Console.WriteLine("Вы исчерпади количество попыток, обр к админ";)
        }
    }

    // run (userAvtorized);
}