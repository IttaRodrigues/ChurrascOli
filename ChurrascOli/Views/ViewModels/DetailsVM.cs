using ChurrascOli.Models;

namespace ChurrascOli.ViewModels;

public class DetailsVM
{
    public Churrasco Anterior { get; set; }
    public Churrasco Atual { get; set; }
    public Churrasco Proximo { get; set; }
}