using System;
using System.Collections.Generic;
using System.Text;
using CoreApi.Infrastructure.Features.Common;
using CoreApi.Infrastructure.Features.File;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreApi.Models.Core
{
    public class UploadedFile : EntityBase, IFileEntity
    {
        public int FileId
        {
            get { return Id; }
            set { }
        }

        public string FileName { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public bool Deleted { get; set; }
    }

    public class UploadedFileConfiguration : EntityBaseConfiguration<UploadedFile>
    {
        public override void ConfigureDerived(EntityTypeBuilder<UploadedFile> builder)
        {
            builder.Ignore(x => x.FileId);
            builder.Property(x => x.FileName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Path).IsRequired().HasMaxLength(200);
        }
    }
}
