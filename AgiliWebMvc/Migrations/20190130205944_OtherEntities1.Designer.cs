﻿// <auto-generated />
using System;
using AgiliWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgiliWebMvc.Migrations
{
    [DbContext(typeof(AgiliWebMvcContext))]
    [Migration("20190130205944_OtherEntities1")]
    partial class OtherEntities1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgiliWebMvc.Models.Adm", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cpf_adm");

                    b.Property<string>("nome_adm");

                    b.Property<string>("senha_adm");

                    b.HasKey("id");

                    b.ToTable("Adm");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Funcionarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Admid");

                    b.Property<string>("cpf_func");

                    b.Property<string>("nome_func");

                    b.Property<string>("senha_func");

                    b.HasKey("id");

                    b.HasIndex("Admid");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Itens_Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Pedidosid");

                    b.Property<int?>("listaProdutosid");

                    b.Property<int>("qtd_itensPedido");

                    b.HasKey("id");

                    b.HasIndex("Pedidosid");

                    b.HasIndex("listaProdutosid");

                    b.ToTable("Itens_Pedidos");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.ListaProduto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Restaurantesid");

                    b.Property<string>("nome_prod");

                    b.Property<double>("valor_produto");

                    b.HasKey("id");

                    b.HasIndex("Restaurantesid");

                    b.ToTable("ListaProduto");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Funcionariosid");

                    b.Property<DateTime>("data_pedido");

                    b.Property<int>("quantidadeTotal_pedidos");

                    b.Property<double>("valorTotal_pedidos");

                    b.HasKey("id");

                    b.HasIndex("Funcionariosid");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Restaurantes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Admid");

                    b.Property<string>("cnpj_rest");

                    b.Property<string>("endereco_rest");

                    b.Property<string>("nome_rest");

                    b.Property<string>("senha_rest");

                    b.Property<string>("telefone_rest");

                    b.HasKey("id");

                    b.HasIndex("Admid");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Funcionarios", b =>
                {
                    b.HasOne("AgiliWebMvc.Models.Adm")
                        .WithMany("Func")
                        .HasForeignKey("Admid");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Itens_Pedido", b =>
                {
                    b.HasOne("AgiliWebMvc.Models.Pedido", "Pedidos")
                        .WithMany("Itens")
                        .HasForeignKey("Pedidosid");

                    b.HasOne("AgiliWebMvc.Models.ListaProduto", "listaProdutos")
                        .WithMany()
                        .HasForeignKey("listaProdutosid");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.ListaProduto", b =>
                {
                    b.HasOne("AgiliWebMvc.Models.Restaurantes", "Restaurantes")
                        .WithMany("listaProdutos")
                        .HasForeignKey("Restaurantesid");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Pedido", b =>
                {
                    b.HasOne("AgiliWebMvc.Models.Funcionarios", "Funcionarios")
                        .WithMany("Pedidos")
                        .HasForeignKey("Funcionariosid");
                });

            modelBuilder.Entity("AgiliWebMvc.Models.Restaurantes", b =>
                {
                    b.HasOne("AgiliWebMvc.Models.Adm")
                        .WithMany("Restaurantes")
                        .HasForeignKey("Admid");
                });
#pragma warning restore 612, 618
        }
    }
}
