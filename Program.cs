using static System.Console;
public class Program
{
    static void Demo6()
    {
      int[] numeros = new int[] {0,2,4,6,8};
      WriteLine($"Digite o número que gostaria de encontrar");
      var numero = int.Parse(ReadLine());
      var idxEncontrado = EncontrarNumero(numeros, numero);

      if(idxEncontrado >= 0)
      {
         WriteLine($"O número digitado está na posição {idxEncontrado}");
      }
      else
      {
          WriteLine("O número digitado não foi encontrado");
      }
    }
    static void Demo5()
    {
       int[] pares = new int[]{0,2,4,6,8};
       MudarParaImpar(pares);
       WriteLine($"Os ímpares {string.Join(",", pares)}");
    }
    static void Demo4()
    {
       string nome = "Cláudia";
       TrocarNome(nome, "Roberta");
       WriteLine($"O novo nome é {nome}");
    }
    static void Demo3()
    {
      StructPessoa p1 = new StructPessoa
       {
           Documento = "486426",
           Idade = 24,
           Nome = "Cláudia"
       };

       var p2 = p1;

       p1 = TrocarNome(p1, "Cláudia");
       
       WriteLine($@"
        Nome do p1 {p1.Nome}
        Nome do p2 {p2.Nome}
       ");

    }
    static void Demo2()
    {
       Pessoa p1 = new Pessoa();
       p1.Nome = "Cláudia";
       p1.Idade = 24;
       p1.Documento = "486426";

       Pessoa p2 = p1.Clone();

       TrocarNome(p1, "Roberta");

       WriteLine($@"
       O nome  de p1 é :{p1.Nome}
       O nome  de p2 é :{p2.Nome}
       ");

    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variável a é {a}");
    }
    static int Adicionar20(int x)
    {
       return x + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }
    
    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }
    static  void MudarParaImpar(int[] pares)
    {
        for (int i = 0; 1 < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
                return i;
        }
        return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
       foreach (var item in pessoas)
       {
          if(item.Nome == pessoa.Nome) 
          {
              return true;
          }
       }
       return false;
    }
    static bool EncontrarPessoa(List<StructPessoa> pessoas, Pessoa pessoa)
    {
       foreach (var item in pessoas)
       {
          if(item.Equals(pessoa)) 
          {
              return true;
          }
       }
       return false;
    }


    public static void Main()
    {
      List<StructPessoa> pessoas = new List<StructPessoa>()
      {
          new StructPessoa(){Nome = "Taciana"},
          new StructPessoa(){Nome = "Eugenio"},
          new StructPessoa(){Nome = "Cláudia"},
          new StructPessoa(){Nome = "Marianne"},
          new StructPessoa(){Nome = "Rita"},
      };

      WriteLine("Digite a pessoa que gostaria de localizar:");
      var nome = ReadLine();
      var pessoa = new StructPessoa(){Nome = nome};
      var encontrado = EncontrarPessoa(pessoas, pessoa);
      if(encontrado)
      {
          WriteLine("Pessoa localizada!");
      }
      else
      {
          WriteLine("Pessoa não encontrada!");
      }

    }

}
