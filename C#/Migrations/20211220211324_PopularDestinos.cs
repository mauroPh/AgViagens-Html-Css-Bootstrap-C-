using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaDeViagens.Migrations
{
    public partial class PopularDestinos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Destinos (DestinoNome , Descricao) " + "VALUES('Porto Seguro - BA', 'Uma das cidades mais animadas do Brasil.Praia, axé e um centro histórico encantador.')");
            migrationBuilder.Sql("INSERT INTO Destinos (DestinoNome , Descricao) " + "VALUES('Rio de Janeiro', 'Uma metrópole urbana movida pela cadência do samba.')");
            migrationBuilder.Sql("INSERT INTO Destinos (DestinoNome , Descricao) " + "VALUES('Florianópolis-SC', 'Nomeada pela revista brasileira semanal Veja “o melhor lugar para se viver no Brasil”! ')");
            migrationBuilder.Sql("INSERT INTO Destinos (DestinoNome , Descricao) " + "VALUES('Fortaleza - CE', 'As praias são a principal atração desta  bela cidade ensolarada.')");
            migrationBuilder.Sql("INSERT INTO Destinos (DestinoNome , Descricao) " + "VALUES('Curitiba - PR', 'O Jardim Botânico de Curitiba em estilo francês é uma das atrações mais populares desta cidade brasileira, com flores, lagos, caminhos e estufa art nouveau, que criam uma atmosfera de sonhos de doce fragrância.')");
            migrationBuilder.Sql("INSERT INTO Destinos (DestinoNome , Descricao) " + "VALUES('Natal-RN', 'A cidade tem o ar mais puro do continente, de acordo com a NASA.Portal para deslumrantes praias !')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Destinos");


        }
    }
}
