using ChurrascOli.ViewModels;

namespace ChurrascOli.ViewModels
{
    public class DetailsVM
    {
        public ChurrascoVM Atual { get; set; }

        public ChurrascoVM Anterior { get; set; }
        public ChurrascoVM Proximo { get; set; }
    }

    public class ChurrascoVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public TipoVM TipoId { get; set; }
    }

    public class TipoVM
    {
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}
