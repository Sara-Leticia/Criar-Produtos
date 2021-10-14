using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdasPet.Areas.Loja.Pages.Testes
{
    public class CriarProdutosModel : PageModel
    {
        public ApplicationDbContext _context { get; set; }
        private readonly UserManager<IdentityUser> _userManager;


        private List<string> Fornecedores { get; } = new List<string>() { 
            "apolo" , "amigopet" , "kittypets", "capitaopet", "thom"
        };

        public CriarProdutosModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public void OnGet()
        {
        }

        public async void OnPostCriarFornecedores()
        {
            foreach (var item in Fornecedores)
            {
                string nome = item + "@adaspet.com.br";
                await _userManager.CreateAsync(new IdentityUser { UserName = nome, Email = nome }, "1Ad@s2");
            }
        }

        public void OnPost()
        {
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o grande porte 2Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 25,
                QtdEmEstoque = 412,
                PrecisaDeCarro = false,
                Descricao = "Ra��o de �tima qualidade",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o grande porte 2Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 30,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Ra��o para fortalecer os ossos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o 15Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 65.50,
                QtdEmEstoque = 100,
                PrecisaDeCarro = false,
                Descricao = "Ra��o super premiun",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o 15Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 70,
                QtdEmEstoque = 110,
                PrecisaDeCarro = false,
                Descricao = "Ra��o para c�es agiatados",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o m�dio porte 2Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 23.50,
                QtdEmEstoque = 100,
                PrecisaDeCarro = false,
                Descricao = "Ra��o super premiun para gatos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o m�dio porte 2Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 24,
                QtdEmEstoque = 150,
                PrecisaDeCarro = false,
                Descricao = "Ra��o natural para gatos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Mistura de sementes Roedores",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 16.30,
                QtdEmEstoque = 251,
                PrecisaDeCarro = false,
                Descricao = "Mistura de sementes para seu roedor ficar feliz",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o extrusada 1Kg",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 30,
                QtdEmEstoque = 326,
                PrecisaDeCarro = false,
                Descricao = "Ra��o extrusada para lagartos diversos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o extrusada 500g",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 26.99,
                QtdEmEstoque = 123,
                PrecisaDeCarro = false,
                Descricao = "Ra��o completa e equilibrada para seu coelho",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ra��o granulada 250g",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 25.39,
                QtdEmEstoque = 230,
                PrecisaDeCarro = false,
                Descricao = "Alimento para peixes carn�voros",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Petisco",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 5,
                QtdEmEstoque = 412,
                PrecisaDeCarro = false,
                Descricao = "Petisco delicioso para seu c�o",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Petisco",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Alimentacao,
                Preco = 6,
                QtdEmEstoque = 400,
                PrecisaDeCarro = false,
                Descricao = "Petisco delicioso para seu gato",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Antipulgas e Carrapatos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 86,
                QtdEmEstoque = 185,
                PrecisaDeCarro = false,
                Descricao = "Shampoo para deixar os carrapatos longe do seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Antipulgas e Carrapatos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 80,
                QtdEmEstoque = 187,
                PrecisaDeCarro = false,
                Descricao = "Shampoo para deixar as pulgas longe do seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vermifugo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 45,
                QtdEmEstoque = 145,
                PrecisaDeCarro = false,
                Descricao = "Feito para eliminar os vermes do seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vermifugo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 30,
                QtdEmEstoque = 200,
                PrecisaDeCarro = false,
                Descricao = "Feito para acabar os vermes do seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Antitoxico",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 20,
                QtdEmEstoque = 185,
                PrecisaDeCarro = false,
                Descricao = "Usado contra veneno",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Antitoxico",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 22,
                QtdEmEstoque = 180,
                PrecisaDeCarro = false,
                Descricao = "Usado contra venenos que seu pet possa ter ingerido",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Probi�tico",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 79.8,
                QtdEmEstoque = 201,
                PrecisaDeCarro = false,
                Descricao = "Usado para melhorar a absor��o de nutrientes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Probi�tico",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 80,
                QtdEmEstoque = 220,
                PrecisaDeCarro = false,
                Descricao = "Usado para auxiliar na s�ntese de prote�nas",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pomadas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 31.5,
                QtdEmEstoque = 196,
                PrecisaDeCarro = false,
                Descricao = "Usado para eliminar a sarna do seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pomadas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 32,
                QtdEmEstoque = 190,
                PrecisaDeCarro = false,
                Descricao = "Usado para combater queimaduras",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pomadas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 30,
                QtdEmEstoque = 100,
                PrecisaDeCarro = false,
                Descricao = "Usado para acabar com as assuduras do seu pet ",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pomadas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 24,
                QtdEmEstoque = 50,
                PrecisaDeCarro = false,
                Descricao = "Usado para tirar a sarna",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pomadas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 12,
                QtdEmEstoque = 150,
                PrecisaDeCarro = false,
                Descricao = "Ameniza as dores e as inflama��es",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pomadas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 10,
                QtdEmEstoque = 60,
                PrecisaDeCarro = false,
                Descricao = "Cicatriza as feridas",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pomadas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 50,
                QtdEmEstoque = 121,
                PrecisaDeCarro = false,
                Descricao = "Combate infec��es bacterianas",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vitaminas e Suplementos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 26,
                QtdEmEstoque = 199,
                PrecisaDeCarro = false,
                Descricao = "Ajuda na diminui��o de pelos em excesso",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vitaminas e Suplementos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 24,
                QtdEmEstoque = 119,
                PrecisaDeCarro = false,
                Descricao = "Aumenta a imunidade",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vitaminas e Suplementos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 40,
                QtdEmEstoque = 110,
                PrecisaDeCarro = false,
                Descricao = "Ajuda no desenvolvimento muscular",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vitaminas e Suplementos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 65,
                QtdEmEstoque = 90,
                PrecisaDeCarro = false,
                Descricao = "Auxilia na preven��o de problemas �sseos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vitaminas e Suplementos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 44,
                QtdEmEstoque = 130,
                PrecisaDeCarro = false,
                Descricao = "Ajuda a prevenir problemas dent�rios",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vitaminas e Suplementos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 66,
                QtdEmEstoque = 111,
                PrecisaDeCarro = false,
                Descricao = "Aumenta a energia",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Vitaminas e Suplementos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Farmacia,
                Preco = 88,
                QtdEmEstoque = 131,
                PrecisaDeCarro = false,
                Descricao = " Ajuda a prevenir problemas digestivos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Tapete Higienico",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 34,
                QtdEmEstoque = 165,
                PrecisaDeCarro = false,
                Descricao = "Absor��o ultra r�pida",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Banheiros para cachorros",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 85,
                QtdEmEstoque = 25,
                PrecisaDeCarro = false,
                Descricao = "Mantem o local higienizado",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Coletor de fezes",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 18.99,
                QtdEmEstoque = 45,
                PrecisaDeCarro = false,
                Descricao = "Facilita o recolhimento dos dejetos do seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Shampoo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 29.6,
                QtdEmEstoque = 95,
                PrecisaDeCarro = false,
                Descricao = "Cheiro de melancia",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Shampoo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 30,
                QtdEmEstoque = 90,
                PrecisaDeCarro = false,
                Descricao = "Deixa os pelos macios",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Cortador de unha",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 31,
                QtdEmEstoque = 88,
                PrecisaDeCarro = false,
                Descricao = "Cortador super afiado",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Shampoo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 20,
                QtdEmEstoque = 100,
                PrecisaDeCarro = false,
                Descricao = "Cortador para unhas duras",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Sabonete",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 19.9,
                QtdEmEstoque = 125,
                PrecisaDeCarro = false,
                Descricao = "Sabonete com cheiro de rosas",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Sabonete",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 25,
                QtdEmEstoque = 120,
                PrecisaDeCarro = false,
                Descricao = "Sabonete de coco para gatos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Escova Rasqueadeira",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 36.5,
                QtdEmEstoque = 165,
                PrecisaDeCarro = false,
                Descricao = "Remove os pelos mortos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Escova Rasqueadeira",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 37,
                QtdEmEstoque = 160,
                PrecisaDeCarro = false,
                Descricao = "Facilita na escova��o do pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Caixa de Areia",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 36,
                QtdEmEstoque = 111,
                PrecisaDeCarro = false,
                Descricao = "Tamanmho m�dio com grande profundidade",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Areia higienica",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 26,
                QtdEmEstoque = 120,
                PrecisaDeCarro = false,
                Descricao = "Melhora o controle de odores",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pazinha Coletora",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 4.1,
                QtdEmEstoque = 125,
                PrecisaDeCarro = false,
                Descricao = "Aumenta a praticidade na coleta de fezes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "P� de banho",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Higiene,
                Preco = 22,
                QtdEmEstoque = 68,
                PrecisaDeCarro = false,
                Descricao = "Tira a umidade do pelo do animal",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Bolinha",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 12,
                QtdEmEstoque = 136,
                PrecisaDeCarro = false,
                Descricao ="Feita de Borracha",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ossinho",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 14.5,
                QtdEmEstoque = 156,
                PrecisaDeCarro = false,
                Descricao = "Ajuda na limpeza bucal",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Ratinho",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 6,
                QtdEmEstoque = 159,
                PrecisaDeCarro = false,
                Descricao = "Ratinho de pelucia para divers�o do seu gato",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Varinha",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 15.6,
                QtdEmEstoque = 185,
                PrecisaDeCarro = false,
                Descricao = "Varinha com cord�es",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Arranhador",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 99,
                QtdEmEstoque = 14,
                PrecisaDeCarro = false,
                Descricao = "Ajuda a afiar e lixar as unhas do bichano",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Bichinhos de Pelucia",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 48,
                QtdEmEstoque = 52,
                PrecisaDeCarro = false,
                Descricao = "Feito com algod�o",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Bichinhos de Pelucia",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 50,
                QtdEmEstoque = 60,
                PrecisaDeCarro = false,
                Descricao = "Feito de l�",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Mordedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 19.5,
                QtdEmEstoque = 76,
                PrecisaDeCarro = false,
                Descricao = "Feito de silicon",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Balan�o",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 19.5,
                QtdEmEstoque = 12,
                PrecisaDeCarro = false,
                Descricao = "Balan�o m�dio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Trapezio",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 21,
                QtdEmEstoque = 26,
                PrecisaDeCarro = false,
                Descricao = "Trapezio grande",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Escada",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 30,
                QtdEmEstoque = 63,
                PrecisaDeCarro = false,
                Descricao = "Escada de madeiras para p�ssaros de porte m�dio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Argolas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 20,
                QtdEmEstoque = 62,
                PrecisaDeCarro = false,
                Descricao = "Argolas m�dias de balan�o",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Cabana",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 24,
                QtdEmEstoque = 32,
                PrecisaDeCarro = false,
                Descricao = "Cabana pequena para p�ssaros de pequeno porte",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Espiral",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 23,
                QtdEmEstoque = 30,
                PrecisaDeCarro = false,
                Descricao = "Feito para entreter a ave e aliviar o estresse",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Roda de exerc�cio",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 34,
                QtdEmEstoque = 14,
                PrecisaDeCarro = false,
                Descricao = "Roda naturalmente silenciosa e leve",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Roedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 22,
                QtdEmEstoque = 45,
                PrecisaDeCarro = false,
                Descricao = "Tranquiliza o pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Roedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 25,
                QtdEmEstoque = 50,
                PrecisaDeCarro = false,
                Descricao = "Ajuda na limpeza dental",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pedra mineral",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 8.5,
                QtdEmEstoque = 75,
                PrecisaDeCarro = false,
                Descricao = "Desenvolvida especialmente para atender a necessidade de roer de coelhos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pedra mineral",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 9,
                QtdEmEstoque = 65,
                PrecisaDeCarro = false,
                Descricao = "Feita especialmente para atender a necessidade dos roedores de roer para desgastar os dentes",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pedra mineral",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 10,
                QtdEmEstoque = 50,
                PrecisaDeCarro = false,
                Descricao = "Melhora as fun��es do aparelho digestivo ",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Tunel",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 25,
                QtdEmEstoque = 66,
                PrecisaDeCarro = false,
                Descricao = "Tuneis feitos para a distra��o do seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Tunel",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 21,
                QtdEmEstoque = 70,
                PrecisaDeCarro = false,
                Descricao = "Tuneil m�dio feito de poli�ster dur�vel",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Tubos",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Brinquedos,
                Preco = 19,
                QtdEmEstoque = 68,
                PrecisaDeCarro = false,
                Descricao = "�timos para seu pet fazer exerc�cios",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Coleira tamanho P",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 45,
                QtdEmEstoque = 300,
                PrecisaDeCarro = false,
                Descricao = "Para voc� passear com seu cachorro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Coleira tamanho M",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 25,
                QtdEmEstoque = 412,
                PrecisaDeCarro = false,
                Descricao = "Coleira super resistente",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Coleira tamanho G",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 65.50,
                QtdEmEstoque = 100,
                PrecisaDeCarro = false,
                Descricao = "Coleira confort�vel para seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Coleira tamanho P",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 19.90,
                QtdEmEstoque = 123,
                PrecisaDeCarro = false,
                Descricao = "Para voc� passear com seu gato",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Coleira tamanho G",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 40.99,
                QtdEmEstoque = 100,
                PrecisaDeCarro = false,
                Descricao = "Coleira com peitoral",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Focinheira tamanho P",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 26.30,
                QtdEmEstoque = 350,
                PrecisaDeCarro = false,
                Descricao = "Para seu c�o usar pela prote��o das pessoas",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Caixa de transporte m�dia",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 36.90,
                QtdEmEstoque = 230,
                PrecisaDeCarro = false,
                Descricao = "Uma forma pratica de transportar seu cachorro de um lugar para o outro de forma segura",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Caixa de transporte pequena",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 25.90,
                QtdEmEstoque = 210,
                PrecisaDeCarro = false,
                Descricao = "Uma forma pratica de transportar seu gato de um lugar para o outro de forma segura",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Caminha m�dia",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 39.99,
                QtdEmEstoque = 132,
                PrecisaDeCarro = false,
                Descricao = "Para seu cachorro dormir",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Caminha pequena",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 29,
                QtdEmEstoque = 321,
                PrecisaDeCarro = false,
                Descricao = "Para seu gato descansar confortvelmente",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Filtro interno",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 45,
                QtdEmEstoque = 123,
                PrecisaDeCarro = false,
                Descricao = "Melhora a qualidade da �gua do seu aqu�rio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Substrato",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 5.50,
                QtdEmEstoque = 102,
                PrecisaDeCarro = false,
                Descricao = "Decora o fundo do seu aqu�rio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Aqu�rio de 1L",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 25.90,
                QtdEmEstoque = 156,
                PrecisaDeCarro = false,
                Descricao = "Aqu�rio de vidro",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "L�mpada para aqu�rio",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 86.90,
                QtdEmEstoque = 63,
                PrecisaDeCarro = false,
                Descricao = "Para plantas aqu�ticas",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Termostato para aqu�rio",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 67.99,
                QtdEmEstoque = 55,
                PrecisaDeCarro = false,
                Descricao = "Aquese seu aqu�rio e mant�m uma temperatura estavel",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Rocha Decorativa",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 43.99,
                QtdEmEstoque = 44,
                PrecisaDeCarro = false,
                Descricao = "Decora o ambiente",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Rocha Decorativa",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 45,
                QtdEmEstoque = 55,
                PrecisaDeCarro = false,
                Descricao = "Rocha de tamanho m�dio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Tronco Decorativo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 27.99,
                QtdEmEstoque = 32,
                PrecisaDeCarro = false,
                Descricao = "Decora o ambiente",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Tronco Decorativo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 44,
                QtdEmEstoque = 40,
                PrecisaDeCarro = false,
                Descricao = "Para decora��o",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Planta Artificial",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 15.90,
                QtdEmEstoque = 85,
                PrecisaDeCarro = false,
                Descricao = "Cria um ambiente natural",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Planta Artificial",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 15,
                QtdEmEstoque = 72,
                PrecisaDeCarro = false,
                Descricao = "Planta de tamnaho pequeno",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Sinf�o manual",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 20.50,
                QtdEmEstoque = 65,
                PrecisaDeCarro = false,
                Descricao = "Ajuda na limpeza do substrato do aqu�rio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "M�dias biol�gicas",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 25.60,
                QtdEmEstoque = 96,
                PrecisaDeCarro = false,
                Descricao = "Cria as bacterias necess�rias para melhorar seu aqu�rio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Carv�o ativo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 25.30,
                QtdEmEstoque = 38,
                PrecisaDeCarro = false,
                Descricao = "Tira o mau cheiro do aqu�rio",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Esponja Biol�gica",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 13.90,
                QtdEmEstoque = 85,
                PrecisaDeCarro = false,
                Descricao = "Ajuda na filtragem de res�duos maiores",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Refil para filtro externo",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Peixe,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 19.90,
                QtdEmEstoque = 90,
                PrecisaDeCarro = false,
                Descricao = "Cont�m a manta acr�lica e o carv�o ativado",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Gaiola Pequena",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 99.90,
                QtdEmEstoque = 45,
                PrecisaDeCarro = false,
                Descricao = "Gaiola usada para transporte de aves",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Poleiro Pequeno",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 20,
                QtdEmEstoque = 74,
                PrecisaDeCarro = false,
                Descricao = "Vara disposta horizontalmente em que as aves pousam e dormem",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Comedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 5.90,
                QtdEmEstoque = 69,
                PrecisaDeCarro = false,
                Descricao = "Pote de alimenta��o para seu pet",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Bebedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Passaro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 6,
                QtdEmEstoque = 95,
                PrecisaDeCarro = false,
                Descricao = "Bebedor de pl�stico",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pote de Ra��o",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 30,
                QtdEmEstoque = 74,
                PrecisaDeCarro = false,
                Descricao = "Pote de ra��o grande",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pote de �gua",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Cachorro,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 20,
                QtdEmEstoque = 74,
                PrecisaDeCarro = false,
                Descricao = "Pote de �gua grande para cachorros",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pote de Ra��o",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 25,
                QtdEmEstoque = 45,
                PrecisaDeCarro = false,
                Descricao = "Pote de ra��o pequeno para gatos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Pote de �gua",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Gato,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 26,
                QtdEmEstoque = 46,
                PrecisaDeCarro = false,
                Descricao = "Pote de �gua pequeno para gatos",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Comedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 15.90,
                QtdEmEstoque = 45,
                PrecisaDeCarro = false,
                Descricao = "Pote de pl�stico para alimento",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Bebedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Roedores,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 14.99,
                QtdEmEstoque = 35,
                PrecisaDeCarro = false,
                Descricao = "Pote de pl�stico para �gua",
                ContaCadastro = _context.Users.Where(o => o.UserName == "capitaopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Comedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 14.99,
                QtdEmEstoque = 44,
                PrecisaDeCarro = false,
                Descricao = "Pote m�dio para alimento",
                ContaCadastro = _context.Users.Where(o => o.UserName == "apolo@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Bebedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Coelho,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 15,
                QtdEmEstoque = 48,
                PrecisaDeCarro = false,
                Descricao = "Pote m�dio para �gua",
                ContaCadastro = _context.Users.Where(o => o.UserName == "amigopet@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Comedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 13.99,
                QtdEmEstoque = 55,
                PrecisaDeCarro = false,
                Descricao = "Pote pequeno para alimento",
                ContaCadastro = _context.Users.Where(o => o.UserName == "kittypets@adaspet.com.br").First()
            });
            _context.Produto.Add(new Produto()
            {
                Nome = "Bebedor",
                Marca = "Vermelha",
                TipoDeAnimal = ProdutoAnimais.Repteis,
                Categoria = ProdutoCategorias.Acessorio,
                Preco = 15.30,
                QtdEmEstoque = 45,
                PrecisaDeCarro = false,
                Descricao = "Pote pequeno para �gua",
                ContaCadastro = _context.Users.Where(o => o.UserName == "thom@adaspet.com.br").First()
            });
            _context.SaveChanges();
        }
       
    }
}
