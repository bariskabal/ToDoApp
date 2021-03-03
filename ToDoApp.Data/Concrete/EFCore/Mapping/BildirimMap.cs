using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Data.Concrete.EFCore.Mapping
{
    public class BildirimMap : IEntityTypeConfiguration<Bildirim>
    {
        public void Configure(EntityTypeBuilder<Bildirim> builder)
        {
            builder.HasKey(I=>I.Id);
            builder.Property(I=>I.Id).UseIdentityColumn();

            builder.Property(I=>I.Aciklama).HasColumnType("ntext").IsRequired();

            builder.HasOne(I=>I.AppUser).WithMany(I=>I.Bildirimler).HasForeignKey(I=>I.AppUserId);
        }
    }
}