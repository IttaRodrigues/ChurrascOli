using ChurrascOli.Models;

namespace ChurrascOli.ViewModels;

public class HomeVM
{
    public List<Tipo> Tipos { get; set; }
    public List<Churrasco> Churrascos { get; set; }
}
