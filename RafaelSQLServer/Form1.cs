using System.Data.SqlClient;

namespace RafaelSQLServer
{
    public partial class Form1 : Form
    {
        const string stringDeConexao =
                "Data Source=LAB01-D03\\SQLEXPRESS;Initial Catalog=MinhaBaseDeDados;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void CriarTabela(object sender, EventArgs e)
        {
            string stringDeComando =
                "CREATE TABLE Clientes(Id INT PRIMARY KEY, Nome NVARCHAR(100), Telefone NVARCHAR(15), Idade INT)";
            ConectarEExecutar(stringDeComando);
            MessageBox.Show("Tabela 'Clientes' criada com sucesso!");
        }

        private void InserirDados(object sender, EventArgs e)
        {
            string stringDeComando =
                "INSERT INTO Clientes(Id, Nome, Telefone, Idade) VALUES(1, 'Rafael', '123456789', 19)";
            ConectarEExecutar(stringDeComando);
            MessageBox.Show("Dado inserido com sucesso!");
        }

        private void AtualizarDados(object sender, EventArgs e)
        {
            string stringDeComando =
                "UPDATE Clientes SET Nome = 'Rafael Atualizado', Telefone = '987654321', Idade = 20 WHERE Id = 1";
            ConectarEExecutar(stringDeComando);
            MessageBox.Show("Dado atualizado com sucesso!");
        }

        private void LerDados(object sender, EventArgs e)
        {
            string stringDeComando = "SELECT * FROM Clientes";
            try
            {
                using (SqlConnection conexao = new SqlConnection(stringDeConexao))
                {
                    SqlCommand comando = new SqlCommand(stringDeComando, conexao);
                    conexao.Open();

                    SqlDataReader leitor = comando.ExecuteReader();

                    string resultado = "";
                    while (leitor.Read())
                    {
                        resultado +=
                            $"ID: {leitor["Id"]}\nNome: {leitor["Nome"]}\nTelefone: {leitor["Telefone"]}\nIdade: {leitor["Idade"]}\n\n";
                    }

                    if (string.IsNullOrWhiteSpace(resultado))
                        resultado = "Nenhum dado encontrado.";

                    MessageBox.Show(resultado, "Leitura de Dados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao ler dados");
            }
        }

        private void ApagarDados(object sender, EventArgs e)
        {
            string stringDeComando = "DELETE FROM Clientes WHERE Id = 1";
            ConectarEExecutar(stringDeComando);
            MessageBox.Show("Dado apagado com sucesso!");
        }

        private void DeletarTabela(object sender, EventArgs e)
        {
            string stringDeComando = "DROP TABLE Clientes";
            ConectarEExecutar(stringDeComando);
            MessageBox.Show("Tabela 'Clientes' apagada com sucesso!");
        }

        private void EnviarDados(object sender, EventArgs e)
        {
            int id;
            int idade;
            string nome = Controls["textBoxNome"].Text;
            string telefone = Controls["textBoxTelefone"].Text;

            if (!int.TryParse(Controls["textBoxId"].Text, out id))
            {
                MessageBox.Show("ID inválido. Digite um número inteiro.");
                return;
            }

            if (!int.TryParse(Controls["textBoxIdade"].Text, out idade))
            {
                MessageBox.Show("Idade inválida. Digite um número inteiro.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string comandoSql =
                "INSERT INTO Clientes(Id, Nome, Telefone, Idade) VALUES(@id, @nome, @telefone, @idade)";

            try
            {
                using (SqlConnection conexao = new SqlConnection(stringDeConexao))
                using (SqlCommand comando = new SqlCommand(comandoSql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@idade", idade);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Dado adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir dado: {ex.Message}");
            }
        }

        #region Conexão com o Banco e Execução de Comandos
        private static void ConectarEExecutar(string stringDeComando)
        {
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEPTION");
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
        #endregion

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}