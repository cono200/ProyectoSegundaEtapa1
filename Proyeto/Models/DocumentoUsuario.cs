﻿using System;
using System.Collections.Generic;

namespace Proyeto.Models;

public partial class DocumentoUsuario
{
    public int IdDu { get; set; }

    public string? NombreUsuario1 { get; set; }

    public int? IdDocumento1 { get; set; }

    public virtual Documento? IdDocumento1Navigation { get; set; }

    public virtual Usuario? NombreUsuario1Navigation { get; set; }
}
