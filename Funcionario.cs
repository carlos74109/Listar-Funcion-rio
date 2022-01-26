namespace ExercicioLista1.Models
{
    internal class Funcionario
    {
        public string nome;
        public string id;
        public double salario;

        public Funcionario(string nome, string id, double salario)
        {
            this.nome = nome;
            this.id = id;
            this.salario = salario;

        }

        public double aumentarSalario(double porcentagem)
        {
            
            return salario += salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return "Id: " + id
            + ", Name: " + nome
            + ", Salario: " + salario;
        }

    }
}
