# Topicos-3

# SQL Server

- Crie um banco de dados (Locadora) no SSM SQL Server

# Gerenciador de Servidores

- Coloque a cadeia de conexão. EX:(Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True)

# Context -> MeuContexto.cs

- Altere o MeuContexto() de acordo com sua cadeia de conexão

- EX: public MeuContexto() : base("Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True")

# Forms -> Buttons

- Altere as Strings de conexão de acordo com sua cadeia

- EX: string connectionString = "Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True";

# Console do Gerenciador de pacotes

- Rode o comando (Update-Database) 
