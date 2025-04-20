using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Shop.Context;
using API_Shop.Models;
using System.Net;

namespace API_Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public ProductsController(DataBaseContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/Products
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetAllProducts(int pageCount, int pageId)
        {
            var result = _context.Products
                .OrderBy(p => p.Id)
                .Skip(pageId * pageCount)
                .Take(pageCount)
                .ToList();


            return Ok(await _context.Products.ToArrayAsync());
        }

        // GET: api/Products/GetActiveProducts
        [HttpGet("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<ActionResult<IEnumerable<Product>>> GetActiveProducts()
        {
            var ActiveProducts = await _context.Products
                .Where(p => p.IsExists).ToArrayAsync();

            if (!ActiveProducts.Any())
            {
                return NoContent();
            }

            return Ok(ActiveProducts);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAllProducts", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpDelete("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteMultiple([FromQuery] int[] productsId)
        {
            if (productsId == null || !productsId.Any())
                return BadRequest("Product's Id cannot be null or empty!");

            var products = await _context.Products
                                         .Where(p => productsId.Contains(p.Id))
                                         .ToListAsync();

            if (!products.Any())
                return NotFound("No matching products found.");

            _context.Products.RemoveRange(products);
            await _context.SaveChangesAsync();

            return Ok("Products deleted successfully.");
        }


        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
