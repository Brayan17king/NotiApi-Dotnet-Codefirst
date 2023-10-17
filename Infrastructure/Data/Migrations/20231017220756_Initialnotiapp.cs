using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initialnotiapp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blockchain_tiponotificacion_TipoNotificacionesId",
                table: "blockchain");

            migrationBuilder.DropForeignKey(
                name: "FK_genericovssubmodulo_Rol_IdRol",
                table: "genericovssubmodulo");

            migrationBuilder.DropForeignKey(
                name: "FK_genericovssubmodulo_maestrovssubmodulo_IdMaestrovsSubmodulo",
                table: "genericovssubmodulo");

            migrationBuilder.DropForeignKey(
                name: "FK_genericovssubmodulo_permisosgenerico_IdPermisosGenericos",
                table: "genericovssubmodulo");

            migrationBuilder.DropForeignKey(
                name: "FK_maestrovssubmodulo_modulomaestro_IdModuloMaestro",
                table: "maestrovssubmodulo");

            migrationBuilder.DropForeignKey(
                name: "FK_maestrovssubmodulo_submodulos_IdSubmodulo",
                table: "maestrovssubmodulo");

            migrationBuilder.DropForeignKey(
                name: "FK_modulonotificacion_formato_IdFormato",
                table: "modulonotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_modulonotificacion_tiponotificacion_IdTipoNotificacion",
                table: "modulonotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_rolvsmaestro_Rol_IdRol",
                table: "rolvsmaestro");

            migrationBuilder.DropForeignKey(
                name: "FK_rolvsmaestro_modulomaestro_IdModuloMaestro",
                table: "rolvsmaestro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rol",
                table: "Rol");

            migrationBuilder.DropIndex(
                name: "IX_blockchain_TipoNotificacionesId",
                table: "blockchain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tiponotificacion",
                table: "tiponotificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_permisosgenerico",
                table: "permisosgenerico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_modulomaestro",
                table: "modulomaestro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_maestrovssubmodulo",
                table: "maestrovssubmodulo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genericovssubmodulo",
                table: "genericovssubmodulo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_formato",
                table: "formato");

            migrationBuilder.DropColumn(
                name: "TipoNotificacionesId",
                table: "blockchain");

            migrationBuilder.RenameTable(
                name: "Rol",
                newName: "rol");

            migrationBuilder.RenameTable(
                name: "tiponotificacion",
                newName: "tiponotificaciones");

            migrationBuilder.RenameTable(
                name: "permisosgenerico",
                newName: "permisosgenericos");

            migrationBuilder.RenameTable(
                name: "modulomaestro",
                newName: "moduulomaestros");

            migrationBuilder.RenameTable(
                name: "maestrovssubmodulo",
                newName: "maestrosvssubmodulos");

            migrationBuilder.RenameTable(
                name: "genericovssubmodulo",
                newName: "genericovssubmodulos");

            migrationBuilder.RenameTable(
                name: "formato",
                newName: "formatos");

            migrationBuilder.RenameIndex(
                name: "IX_maestrovssubmodulo_IdSubmodulo",
                table: "maestrosvssubmodulos",
                newName: "IX_maestrosvssubmodulos_IdSubmodulo");

            migrationBuilder.RenameIndex(
                name: "IX_maestrovssubmodulo_IdModuloMaestro",
                table: "maestrosvssubmodulos",
                newName: "IX_maestrosvssubmodulos_IdModuloMaestro");

            migrationBuilder.RenameIndex(
                name: "IX_genericovssubmodulo_IdRol",
                table: "genericovssubmodulos",
                newName: "IX_genericovssubmodulos_IdRol");

            migrationBuilder.RenameIndex(
                name: "IX_genericovssubmodulo_IdPermisosGenericos",
                table: "genericovssubmodulos",
                newName: "IX_genericovssubmodulos_IdPermisosGenericos");

            migrationBuilder.RenameIndex(
                name: "IX_genericovssubmodulo_IdMaestrovsSubmodulo",
                table: "genericovssubmodulos",
                newName: "IX_genericovssubmodulos_IdMaestrovsSubmodulo");

            migrationBuilder.AlterColumn<string>(
                name: "NombreRequerimiento",
                table: "tiporequerimiento",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSubmodulo",
                table: "submodulos",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreRol",
                table: "rol",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TextoNotificacion",
                table: "modulonotificacion",
                type: "varchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AsuntoNotificacion",
                table: "modulonotificacion",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "hilorespuestanotificacion",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HasGenerado",
                table: "blockchain",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreUsuario",
                table: "auditoria",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldMaxLength: 40)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "tiponotificaciones",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rol",
                table: "rol",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tiponotificaciones",
                table: "tiponotificaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_permisosgenericos",
                table: "permisosgenericos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_moduulomaestros",
                table: "moduulomaestros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_maestrosvssubmodulos",
                table: "maestrosvssubmodulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genericovssubmodulos",
                table: "genericovssubmodulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_formatos",
                table: "formatos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_blockchain_IdTipoNotificacion",
                table: "blockchain",
                column: "IdTipoNotificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_blockchain_tiponotificaciones_IdTipoNotificacion",
                table: "blockchain",
                column: "IdTipoNotificacion",
                principalTable: "tiponotificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genericovssubmodulos_maestrosvssubmodulos_IdMaestrovsSubmodu~",
                table: "genericovssubmodulos",
                column: "IdMaestrovsSubmodulo",
                principalTable: "maestrosvssubmodulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genericovssubmodulos_permisosgenericos_IdPermisosGenericos",
                table: "genericovssubmodulos",
                column: "IdPermisosGenericos",
                principalTable: "permisosgenericos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genericovssubmodulos_rol_IdRol",
                table: "genericovssubmodulos",
                column: "IdRol",
                principalTable: "rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_maestrosvssubmodulos_moduulomaestros_IdModuloMaestro",
                table: "maestrosvssubmodulos",
                column: "IdModuloMaestro",
                principalTable: "moduulomaestros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_maestrosvssubmodulos_submodulos_IdSubmodulo",
                table: "maestrosvssubmodulos",
                column: "IdSubmodulo",
                principalTable: "submodulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_modulonotificacion_formatos_IdFormato",
                table: "modulonotificacion",
                column: "IdFormato",
                principalTable: "formatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_modulonotificacion_tiponotificaciones_IdTipoNotificacion",
                table: "modulonotificacion",
                column: "IdTipoNotificacion",
                principalTable: "tiponotificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rolvsmaestro_moduulomaestros_IdModuloMaestro",
                table: "rolvsmaestro",
                column: "IdModuloMaestro",
                principalTable: "moduulomaestros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rolvsmaestro_rol_IdRol",
                table: "rolvsmaestro",
                column: "IdRol",
                principalTable: "rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blockchain_tiponotificaciones_IdTipoNotificacion",
                table: "blockchain");

            migrationBuilder.DropForeignKey(
                name: "FK_genericovssubmodulos_maestrosvssubmodulos_IdMaestrovsSubmodu~",
                table: "genericovssubmodulos");

            migrationBuilder.DropForeignKey(
                name: "FK_genericovssubmodulos_permisosgenericos_IdPermisosGenericos",
                table: "genericovssubmodulos");

            migrationBuilder.DropForeignKey(
                name: "FK_genericovssubmodulos_rol_IdRol",
                table: "genericovssubmodulos");

            migrationBuilder.DropForeignKey(
                name: "FK_maestrosvssubmodulos_moduulomaestros_IdModuloMaestro",
                table: "maestrosvssubmodulos");

            migrationBuilder.DropForeignKey(
                name: "FK_maestrosvssubmodulos_submodulos_IdSubmodulo",
                table: "maestrosvssubmodulos");

            migrationBuilder.DropForeignKey(
                name: "FK_modulonotificacion_formatos_IdFormato",
                table: "modulonotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_modulonotificacion_tiponotificaciones_IdTipoNotificacion",
                table: "modulonotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_rolvsmaestro_moduulomaestros_IdModuloMaestro",
                table: "rolvsmaestro");

            migrationBuilder.DropForeignKey(
                name: "FK_rolvsmaestro_rol_IdRol",
                table: "rolvsmaestro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rol",
                table: "rol");

            migrationBuilder.DropIndex(
                name: "IX_blockchain_IdTipoNotificacion",
                table: "blockchain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tiponotificaciones",
                table: "tiponotificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_permisosgenericos",
                table: "permisosgenericos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_moduulomaestros",
                table: "moduulomaestros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_maestrosvssubmodulos",
                table: "maestrosvssubmodulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genericovssubmodulos",
                table: "genericovssubmodulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_formatos",
                table: "formatos");

            migrationBuilder.RenameTable(
                name: "rol",
                newName: "Rol");

            migrationBuilder.RenameTable(
                name: "tiponotificaciones",
                newName: "tiponotificacion");

            migrationBuilder.RenameTable(
                name: "permisosgenericos",
                newName: "permisosgenerico");

            migrationBuilder.RenameTable(
                name: "moduulomaestros",
                newName: "modulomaestro");

            migrationBuilder.RenameTable(
                name: "maestrosvssubmodulos",
                newName: "maestrovssubmodulo");

            migrationBuilder.RenameTable(
                name: "genericovssubmodulos",
                newName: "genericovssubmodulo");

            migrationBuilder.RenameTable(
                name: "formatos",
                newName: "formato");

            migrationBuilder.RenameIndex(
                name: "IX_maestrosvssubmodulos_IdSubmodulo",
                table: "maestrovssubmodulo",
                newName: "IX_maestrovssubmodulo_IdSubmodulo");

            migrationBuilder.RenameIndex(
                name: "IX_maestrosvssubmodulos_IdModuloMaestro",
                table: "maestrovssubmodulo",
                newName: "IX_maestrovssubmodulo_IdModuloMaestro");

            migrationBuilder.RenameIndex(
                name: "IX_genericovssubmodulos_IdRol",
                table: "genericovssubmodulo",
                newName: "IX_genericovssubmodulo_IdRol");

            migrationBuilder.RenameIndex(
                name: "IX_genericovssubmodulos_IdPermisosGenericos",
                table: "genericovssubmodulo",
                newName: "IX_genericovssubmodulo_IdPermisosGenericos");

            migrationBuilder.RenameIndex(
                name: "IX_genericovssubmodulos_IdMaestrovsSubmodulo",
                table: "genericovssubmodulo",
                newName: "IX_genericovssubmodulo_IdMaestrovsSubmodulo");

            migrationBuilder.AlterColumn<string>(
                name: "NombreRequerimiento",
                table: "tiporequerimiento",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSubmodulo",
                table: "submodulos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreRol",
                table: "Rol",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TextoNotificacion",
                table: "modulonotificacion",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2000)",
                oldMaxLength: 2000)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AsuntoNotificacion",
                table: "modulonotificacion",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "hilorespuestanotificacion",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HasGenerado",
                table: "blockchain",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TipoNotificacionesId",
                table: "blockchain",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreUsuario",
                table: "auditoria",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "tiponotificacion",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rol",
                table: "Rol",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tiponotificacion",
                table: "tiponotificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_permisosgenerico",
                table: "permisosgenerico",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_modulomaestro",
                table: "modulomaestro",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_maestrovssubmodulo",
                table: "maestrovssubmodulo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genericovssubmodulo",
                table: "genericovssubmodulo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_formato",
                table: "formato",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_blockchain_TipoNotificacionesId",
                table: "blockchain",
                column: "TipoNotificacionesId");

            migrationBuilder.AddForeignKey(
                name: "FK_blockchain_tiponotificacion_TipoNotificacionesId",
                table: "blockchain",
                column: "TipoNotificacionesId",
                principalTable: "tiponotificacion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_genericovssubmodulo_Rol_IdRol",
                table: "genericovssubmodulo",
                column: "IdRol",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genericovssubmodulo_maestrovssubmodulo_IdMaestrovsSubmodulo",
                table: "genericovssubmodulo",
                column: "IdMaestrovsSubmodulo",
                principalTable: "maestrovssubmodulo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genericovssubmodulo_permisosgenerico_IdPermisosGenericos",
                table: "genericovssubmodulo",
                column: "IdPermisosGenericos",
                principalTable: "permisosgenerico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_maestrovssubmodulo_modulomaestro_IdModuloMaestro",
                table: "maestrovssubmodulo",
                column: "IdModuloMaestro",
                principalTable: "modulomaestro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_maestrovssubmodulo_submodulos_IdSubmodulo",
                table: "maestrovssubmodulo",
                column: "IdSubmodulo",
                principalTable: "submodulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_modulonotificacion_formato_IdFormato",
                table: "modulonotificacion",
                column: "IdFormato",
                principalTable: "formato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_modulonotificacion_tiponotificacion_IdTipoNotificacion",
                table: "modulonotificacion",
                column: "IdTipoNotificacion",
                principalTable: "tiponotificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rolvsmaestro_Rol_IdRol",
                table: "rolvsmaestro",
                column: "IdRol",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rolvsmaestro_modulomaestro_IdModuloMaestro",
                table: "rolvsmaestro",
                column: "IdModuloMaestro",
                principalTable: "modulomaestro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
