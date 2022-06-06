//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace cbsStudents.Models
//{

//    //    public class BufferedSingleFileUploadDbModel : PageModel
//    //    {
//    //    ...

//    //    [BindProperty]
//    //        public BufferedSingleFileUploadDb FileUpload { get; set; }

//    //    ...
//    //}

//    //    public class BufferedSingleFileUploadDb
//    //    {
//    //        [Required]
//    //        [Display(Name = "File")]
//    //        public IFormFile FormFile { get; set; }
//    //    }




//    public class ImageUpload
//    {

//        public int Id { get; set; }
//        public string Title { get; set; }

//        [DisplayName("Image Name")]
//        public string ImageName { get; set; }

//        [NotMapped]
//        [DisplayName("Upload Image")]
//        public IFormFile ImageFile { get; set; }
//    }
//}
