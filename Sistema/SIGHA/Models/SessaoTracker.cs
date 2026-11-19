namespace SIGHA.Models
{
    public static class SessaoTracker
    {
        public static Usuario UsuarioLogado { get; set; }

        public static bool IsAdmin => UsuarioLogado?.Role == "Administrador";
        public static bool IsMedico => UsuarioLogado?.Role == "Medico";
        public static bool IsEnfermeiro => UsuarioLogado?.Role == "Enfermeiro";
        public static bool IsAtendente => UsuarioLogado?.Role == "Atendente";
    }
}
