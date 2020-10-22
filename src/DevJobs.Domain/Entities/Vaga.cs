using System;

namespace DevJobs.Domain.Entities
{
  public class Vaga
  {
    protected Vaga() { }

    public Vaga(string nome)
    {
      VagaId = Guid.NewGuid();

      Nome = nome;
    }

    public Guid VagaId { get; }
    public Guid EmpresaId { get; private set; }
    public string Nome { get; private set; }
    public string Descicao { get; private set; }
    public string EmailContato { get; private set; }

  }
}