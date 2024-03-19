// See https://aka.ms/new-console-template for more information

/*
    Console.WriteLine("Hello, World!");  //aspas duplas cria uma string

    Console.WriteLine('b');  //aspas cimples cria um caractere literal

    Console.WriteLine(123); //um valor inteito naos requer nenhum tipo de aspas

    Console.WriteLine(0.25F);  //no float acresenta-se  F após o número

    //Float Type    Precision
    //----------------------------
    //float         ~6-9 digits
    //double        ~15-17 digits
    //decimal        28-29 digits 

    Console.WriteLine(2.625);  //se o número não tiver nenhum sufuxo no final, será um double

    Console.WriteLine(12.39816m); //Um M ni fu=inal significa valor decimal

    Console.WriteLine(true);     //valor boobleano verdadeiro
    Console.WriteLine(false);   //valor boobleano falso
*/

/*
    TIPOS DE VARIÁVEIS:
        => Um literal é, literalmente, um valor embutido em código. Os valores embutidos diretamente no código são aqueles constantes e inalterados durante a execução do programa.
        => string para palavras, frases ou qualquer dado alfanumérico para apresentação, não cálculo
        => char para um caractere alfanumérico
        => int para um número inteiro
        => decimal para um número com um componente fracionário
        => bool para um valor true/false
*/

/* 
    Uma variável é um contêiner para armazenar um tipo de valor. As variáveis são importantes porque seus valores podem mudar ou variar durante a execução de um programa. As variáveis podem ser atribuídas, lidas e alteradas. Use variáveis para armazenar os valores que pretende usar em seu código

    EXEMPLOS DE VARIAVEL:

        Para criar uma variável, primeiro você deve declarar o tipo de dados que ela armazenará, depois dar um nome a ela

        string firstName;

        char userOption;

        int gameScore;

        decimal particlesPerMillion;

        bool processedCustomer; 
*/

/*
    string firstName;
    firstName = "Bob";
    Console.WriteLine(firstName);
*/

/*VARIAVEIS DOO TIPO IMPLICITO
    Uma variável local de tipo implícito é criada usando a palavra-chave var seguida de uma inicialização de variável.

    EX.: var message = "Hello world!";

    Neste exemplo, uma variável de cadeia de caracteres foi criada usando a palavra-chave var em vez da palavra-chave string.A palavra-chave var informa ao compilador C# que o tipo de dados está implícito pelo valor atribuído
    a variável message é definida para ser um string e para NUNCA poder ser alterada. 
*/

/*
    string name = "Bob";
    int mensagens = 3;
    decimal temperatura = 34.4m;

    Console.WriteLine("Hello, " + name + " You have " + mensagens + " messagens in your inbox. The temperature is " + temperatura + " Celsisus."); //exemplo de uma frase printada com mais de uma variavel concatenada
*/

//CHAMAR MÉTODOS E CLASSES DO .NET USANDO C#:
/*
    => Classes são como seções em uma biblioteca publica
    => Métodos ficam relacionados todos juntos em uma única classe
    => Para encontrar classes e métodos no .NET, se dá na mesma forma como encontramos os livros em uma biblioteca pública

    CHAMAR ÓS MÉTODOS:
        1.  Comece digitando o nome da classe. Neste caso, o nome da classe é Console.
        2.  Adicione o operador de acesso de membro, o símbolo ..
        3.  Adicione o nome do método. Neste caso, o nome do método é WriteLine.
        4.  Adicione o operador de chamada do método, que é um conjunto de parênteses ().
        5.  Finalmente, especifique os argumentos que serão transmitidos ao método, se houver algum, entre os parênteses do operador de invocação de método. Aqui, você especifica o texto que deseja que o método Console.WriteLine() escreva no console (por exemplo, "Hello World!").

    => Se tratando de métodos exitem dois tipos: os qua não deéndem de nenhum valor para funcionar e os que depedendem: os mḿetodo *Console.WriteLine()*  não depende de nenhum valor armazenado na mémodria , ele apenas executa sua função e termina sema fetar o estado do aplicativo de qualquer forma.
    => Uma instância de uma classe é chamada de um objeto.
        O operador new faz várias coisas importantes:
            => Primeiro, ele solicita um endereço na memória do computador grande o suficiente para armazenar um novo objeto com base na classe Random.
            => Ele cria o objeto e o armazena no endereço de memória.
            => Ele retorna o endereço de memória para que ele possa ser salvo na variável dice.
    
    =>
*/