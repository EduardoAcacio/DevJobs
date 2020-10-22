using System;
using System.Collections.Generic;

namespace DevJobs.Domain.Entities
{
  public class Empresa
  {
    protected Empresa() { }

    public Empresa(string nome)
    {
      EmpresaId = Guid.NewGuid();
    }

    public Guid EmpresaId { get; private set; }
    public List<Vaga> Vagas { get; private set; }
    public string Nome { get; private set; }
    public string Descicao { get; private set; }
    public string EmailContato { get; private set; }
  }
}