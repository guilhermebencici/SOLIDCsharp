namespace SOLIDCsharp
{
    class Pessoa
    {
        //field
        public string nome;
        public int idade;
        public string genero;

        // CONSTRUTOR
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public Pessoa()
        {

        }

        public void Identificar()
        {
            System.Console.WriteLine($"Olá, sou o {nome}, tenho {idade} e sou do sexo {genero}");
        }
    }
}
