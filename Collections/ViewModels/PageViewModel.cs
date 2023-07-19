using System.Collections.ObjectModel;
using Collections.Data;
using Collections.Models;

namespace Collections.ViewModels
{
	public class PageViewModel
	{
        private MockPictureService _mockPictureService;

        public ObservableCollection<Picture> Pictures { get; set; }

        public PageViewModel()
        {
            Pictures = new ObservableCollection<Picture>();

            _mockPictureService = new MockPictureService();

            IEnumerable<Picture> localPictues = _mockPictureService.GetAll();

            foreach (Picture picture in localPictues)
            {
                Pictures.Add(picture);
            }
        }
    }
}

