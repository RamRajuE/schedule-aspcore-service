using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using schedule_aspcore_service.Data;
using schedule_aspcore_service.Models;

namespace schedule_aspcore_service.Pages.Schedule
{
    public class IndexModel : PageModel
    {
        private readonly SchedulerDbContext _context;
        public IEnumerable<ScheduleModel> Events { get; set; }

        public IndexModel(SchedulerDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Events = _context.ScheduleTableAspCore;
            return new JsonResult(Events);
        }

        public async Task<IActionResult> OnPostAsync([FromBody] ScheduleModel newEvent)
        {
            _context.ScheduleTableAspCore.Add(newEvent);
            await _context.SaveChangesAsync();
            return new JsonResult(newEvent);
        }

        public async Task<IActionResult> OnPutAsync([FromBody] ScheduleModel updatedEvent)
        {
            _context.ScheduleTableAspCore.Update(updatedEvent);
            await _context.SaveChangesAsync();
            return new JsonResult(updatedEvent);
        }

        public async Task<IActionResult> OnDeleteAsync(int id)
        {
            var eventToDelete = await _context.ScheduleTableAspCore.FindAsync(id);
            if (eventToDelete == null)
            {
                return NotFound();
            }

            _context.ScheduleTableAspCore.Remove(eventToDelete);
            await _context.SaveChangesAsync();
            return new JsonResult(eventToDelete);
        }
    }
}
