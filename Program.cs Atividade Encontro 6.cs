namespace Sistema{
    class Program{
        static void Main(string[] args)
        {

             Console.Clear();
                    void barraCarregamento(string textoCarregamento, string icone){
                Console.Write(textoCarregamento);
                Thread.Sleep(500);
                for (var contador = 0; contador <10; contador ++)
                {             
                Console.Write (icone);
                Thread.Sleep(500);

                }
                Console.WriteLine("");

             }
             
             
             Console.ForegroundColor = ConsoleColor.Cyan;
             Console.BackgroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"


======================================================================================================================

Bem vindo ao sistema de cadastro de pessoa física e juridica

======================================================================================================================= ");
barraCarregamento("Iniciando","$");




string opcao;

do{

            Console.WriteLine(@$"
=======================================================================================================================
|            Escolha uma das opções abaixo
======================================================================================================================= 
|
|               1 - Pessoa Física
|               2 - Pessoa Juridica
|
|                0 - Sair|           
=======================================================================================================================
   ");
                       
    opcao = Console.ReadLine();

   switch (opcao)
   {
    
        case "1":
        Endereco banana = new Endereco();
        banana.logradouro = "Rua X";
        banana.numero = 100;
        banana.complemento = "Perto do senai";
        banana.enderecoComercial = false;

        PessoaFisica Lucas = new PessoaFisica();
        Lucas.endereco = banana;
        Lucas.cpf = "12345678";
        Lucas.dataNasc = new DateTime (2010, 01, 19, 04, 30, 58);
        Lucas.Nome = "Lucas Schiaffino";

        Console.WriteLine(Lucas.endereco.logradouro);
        Console.WriteLine(Lucas.endereco.numero);
        Console.WriteLine(Lucas.endereco.complemento);
        Console.WriteLine(Lucas.endereco.enderecoComercial);
        Console.WriteLine(Lucas.Nome);
        Console.WriteLine(Lucas.cpf);
        Console.WriteLine(Lucas.dataNasc);


        bool idadeValidada = Lucas.ValidarDataNascimento(Lucas.dataNasc);

         if (idadeValidada == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                Seu Cadastro Foi Aprovado                            *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*************************");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*************************");
                Console.ResetColor();
            }




        break;
        case "2":
        Endereco Comm = new Endereco();
        Comm.logradouro = "Rua X";
        Comm.numero =100;
        Comm.complemento = "Perto do senai";
        Comm.enderecoComercial = true;

        PessoaJuridica LC = new PessoaJuridica();
        LC.endereco = Comm;
        LC.cnpj = "123567899001";
        LC.razaoSocial = "Pessoa Juridica";

        bool cnpjvalidado = LC.validarCNPJ(LC.cnpj);

        if(cnpjvalidado == true){
            Console.WriteLine("Verdadeiro - O CNPJ é valido");
        }else{
            Console.WriteLine("Falso - O CNPJ é invalido");
        }
        break;
        case "0":
        barraCarregamento("Encerrando","$");
        Console.ResetColor();
        break;
        default:
        Console.WriteLine("digite uma das opções apresentadas acima");
        break;
   }   

}while(opcao != "0");        

}

          

            
            /*
        Endereco end = new Endereco();
        end.logradouro = "Rua X";
        end.numero = 100;
        end.complemento = "Perto do senai";
        end.enderecoComercial = false;

        PessoaFisica Lucas = new PessoaFisica();
        Lucas.endereco = end;
        Lucas.cpf = "12345678";
        Lucas.dataNasc = new DateTime (2010, 01, 19, 04,30,58);
        Lucas.Nome = "Lucas Schiaffino";

        //Console.WriteLine(Lucas.endereco.logradouro);
        //Console.WriteLine(Lucas.endereco.numero);
        //Console.WriteLine(Lucas.endereco.complemento);
        //Console.WriteLine(Lucas.endereco.enderecoComercial);
       // Console.WriteLine(Lucas.Nome);
        //Console.WriteLine(Lucas.cpf);
        //Console.WriteLine(Lucas.dataNasc);

// O ___ , cujo cpf é ___ e faz aniversario no dia ___ mora na ____ numero ____ 
        //concatenação
    //Console.WriteLine("O " + Lucas.Nome + ", cujo CPF é " + Lucas.cpf + " e nasceu no dia " + Lucas.dataNasc + " mora na " + Lucas.endereco.logradouro + " numero " + Lucas.endereco.numero );

//interpolação
    //Console.WriteLine($"O {Lucas.Nome}, cujo CPF é {Lucas.cpf} e faz aniversario no dia {Lucas.dataNasc} mora na {Lucas.endereco.logradouro} numero {Lucas.endereco.numero}"); 

            //Console.WriteLine(Lucas.ValidarDataNascimento(Lucas.dataNasc));
            bool idadeValidada = Lucas.ValidarDataNascimento(Lucas.dataNasc);
            Console.WriteLine(idadeValidada);

            if (idadeValidada == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                Seu Cadastro Foi Aprovado                            *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.ResetColor();
            }
 */
        }
    }

 


    
    
           



           


