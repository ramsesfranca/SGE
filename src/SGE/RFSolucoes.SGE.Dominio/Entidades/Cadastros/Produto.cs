namespace RFSolucoes.SGE.Dominio.Entidades.Cadastros
{
    public class Produto : EntidadeBase<int>
    {
        #region Propriedades

        public string Nome { get; set; }
        public string CodigoInterno { get; set; }

        #endregion
    }
}
