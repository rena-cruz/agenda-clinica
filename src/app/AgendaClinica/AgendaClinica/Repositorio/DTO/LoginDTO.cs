namespace AgendaClinica.DTO
{
    internal class LoginDTO
    {
        public string Login { get; set; }

        public string Senha { get; set; }

        public LoginDTO(): this(null, null) { }

        public LoginDTO(string pLogin, string pSenha)
        {
            Login = pLogin;
            Senha = pSenha;
        }
    }
}
