using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NeXusERP.WebUI.Pages.Products
{
    [Authorize]
    public class IndexModel : PageModel
    {
       public readonly IProductRepository _productRepository;
       public IEnumerable<Product> Products { get; set; } = new List<Product>();
       public IndexModel(IProductRepository productRepository) => _productRepository = productRepository;
       public async Task OnGetAsync() => Products = await _productRepository.GetAllAsync();
    }
}
