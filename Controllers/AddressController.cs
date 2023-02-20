using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Data;
using MoviesApi.Data.DTO;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private MovieContext _context;
        private IMapper _mapper;

        public AddressController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddAddress([FromBody] CreateAddressDTO addressDTO)
        {
            Address address = _mapper.Map<Address>(addressDTO);
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAddressById), new { Id = address.id }, address);
        }

        [HttpGet]
        public IEnumerable<ReadAddressDTO> ReadAddress()
        {
            return _mapper.Map<List<ReadAddressDTO>>(_context.Addresses);
        }

        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.id == id);
            if (address != null)
            {
                ReadAddressDTO addressDTO = _mapper.Map<ReadAddressDTO>(address);

                return Ok(addressDTO);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDTO addressDTO)
        {
            Address address = _context.Addresses.FirstOrDefault(endereco => endereco.id == id);
            if (address == null)
            {
                return NotFound();
            }
            _mapper.Map(addressDTO, address);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.id == id);
            if (address == null)
            {
                return NotFound();
            }
            _context.Remove(address);
            _context.SaveChanges();
            return NoContent();
        }

    }
}