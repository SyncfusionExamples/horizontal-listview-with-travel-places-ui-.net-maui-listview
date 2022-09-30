using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region PlaceInfoRepository
    public class PlaceInfoRepository
    {
        #region Fields
        public ObservableCollection<string[]> Places;
        public ObservableCollection<string[]> PlacesDescription;
        #endregion

        #region Constructor

        public PlaceInfoRepository()
        {
            Places = new ObservableCollection<string[]> { Place1, Place2, Place3, Place4, Place5, Place6, Place7, Place8, Place9, Place10, Place11, Place12, Place13, Place14, Place15 };
            PlacesDescription = new ObservableCollection<string[]> { Place1Description, Place2Description, Place3Description, Place4Description, Place5Description, Place6Description, Place7Description, Place8Description, Place9Description, Place10Description, Place11Description, Place12Description, Place13Description, Place14Description, Place15Description };
        }
        #endregion

        #region Generate methods

        public ObservableCollection<PlaceInfo> GeneratePlaces()
        {
            var index = 1;
            var places = new ObservableCollection<PlaceInfo>();
            for (int i = 0; i < PlaceNames.Count(); i++)
            {
                var place = new PlaceInfo();
                place.Name = PlaceNames[i];
                place.TouristPlaces = GenerateTouristPlaces(i);
                place.Image = ImageSource.FromResource("ListViewMaui.Images.place_"  + (index++) + ".jpg");
                places!.Add(place);
            }
            return places;
        }

        public ObservableCollection<PlaceInfo> GenerateTouristPlaces(int index)
        {
            var index1 = index + 1;
            var index2 = 1;
            var list = new ObservableCollection<PlaceInfo>();
            var placeDetails = this.Places[index];
            var placeDescriptionDetails = this.PlacesDescription[index];
            for (int i = 0; i < placeDetails.Count(); i++)
            {
                var place = new PlaceInfo();
                place.Name = placeDetails[i];
                place.Description = placeDescriptionDetails[i];
                place.Image = ImageSource.FromResource("ListViewMaui.Images.place" + index1 + "" + (index2++) + ".jpg");
                list!.Add(place);
            }
            return list;
        }
        #endregion

        #region Collections

        readonly string[] PlaceNames = new string[]
        {
            "New York",
            "San Francisco",
            "Chicago",
            "Yosemite National Park",
            "Washington, D.C",
            "Los Angeles",
            "Boston",
            "Seattle",
            "Miami",
            "Las Vegas",
            "San Diego",
            "Atlanta",
            "New Orleans",
            "Orlando",
            "Denver",
        };

        public readonly string[] Place1 = new string[]
       {
            "Central Park",
            "The Metropolitan Museum of Art",
            "Statue of Liberty",
            "Empire State Building",
            "Solomon R. Guggenheim",
            "Times Square",
            "Brooklyn Bridge",
            "American Museum of Natural History",

       };

        readonly string[] Place1Description = new string[]
      {
            "Central Park is an urban park & fifth largest park in New York City.",
            "The Metropolitan Museum is the largest art museum in the Western Hemisphere.",
            "The Statue of Liberty is a colossal neoclassical sculpture on Liberty Island.",
            "The Empire State Building is a 102-story Art Deco skyscraper in Mid-Manhattan.",
            "The Solomon R. Guggenheim Museum is an art museum, Manhattan in New York City.  ",
            "Times Square is a tourist destination in Mid-Manhattan and More.",
            "The Brooklyn Bridge is a hybrid cable-stayed bridge in New York City.",
            "It is a natural history museum on the Upper West Side of Manhattan, New York City.",

      };
        readonly string[] Place2 = new string[]
      {
            "Golden Gate Bridge",
            "Alcatraz Island",
            "San Francisco Museum of Modern",
            "Golden Gate Park",
            "California Academy of Sciences",
            "Lombard Street",
            "Muir Woods National Monument",

      };

        readonly string[] Place2Description = new string[]
      {
            "The one-mile-wide strait connecting San Francisco Bay and the Pacific Ocean.",
            "Alcatraz Island is a small island in San Francisco Bay,California.",
            "It is a modern & contemporary art museum in San Francisco.",
            "The Park is a large urban park consisting of 1,017 acres of public grounds.",
            "The California Academy is a research institute & natural history museum.",
            "It is famous for a steep and one-block section with eight hairpin turns.",
            "It is located on Mount Tamalpais near the Pacific coast, California.",

      };
        readonly string[] Place3 = new string[]
      {
            "The Art Institute of Chicago",
            "Field Museum",
            "Navy Pier",
            "Millennium Park",
            "Shedd Aquarium",
            "Lincoln Park Zoo",
            "Cloud Gate",
            "Willis Tower",
      };

        readonly string[] Place3Description = new string[]
      {
            "The Art Institute of Chicago have been a fixture on the creative landscape.",
            "It is a natural history museum and one of the largest such museums in the world. ",
            "Navy Pier is a 3,300-foot-long pier on the shoreline of Lake Michigan, Chicago.",
            "Millennium Park is a public park located in the Loop community area of Chicago.",
            "Shedd Aquarium is an indoor public aquarium and Opened on May 30, 1930.",
            "The Lincoln Park Zoo is a 35-acre zoo in Lincoln Park, Chicago, Illinois.",
            "The Cloud Gate is a public sculpture by Indian-born British artist Anish Kapoor.",
            "The Willis Tower is a 108-story, 1,450-foot skyscraper in Chicago.",

      };
        readonly string[] Place4 = new string[]
      {
            "Yosemite Falls",
            "Half Dome",
            "Glacier Point",
            "El Capitan",
            "Yosemite Valley",
            "Tunnel view",
            "Bridalveil Fall",
            "The Ahwahnee",
            "Tuolumne Meadows",
      };

        readonly string[] Place4Description = new string[]
      {
            "Yosemite Falls is the highest waterfall in Yosemite National Park, Sierra Nevada.",
            "The Half Dome is a granite dome at the eastern end of Yosemite Valley.",
            "Glacier Point is a viewpoint above Yosemite Valley in California.",
            "The El Capitan is a vertical rock formation in Yosemite National Park.",
            "The Yosemite Valley is a glacial valley in Yosemite National Park.",
            "The Tunnel View is a scenic viewpoint on California State Route 41. ",
            "The Bridalveil Fall is one of the most prominent waterfalls in Yosemite Valley.",
            "The Ahwahnee Hotel is a grand hotel in Yosemite National Park, California.",
            "The Tuolumne Meadows is a gentle, dome- studded, and sub-alpine meadow area.",

      };
        readonly string[] Place5 = new string[]
      {
            "The White House",
            "United States Capitol",
            "Smithsonian Institution",
            "Lincoln Memorial",
            "National Gallery of Art",
            "Smithsonian National Museum of Natural History",
            "Washington Monument",
            "Smithsonian National Air and Space Museum",
      };

        readonly string[] Place5Description = new string[]
      {
            "The White House is the official residence of the US president in Washington DC.",
            "The Capitol is the seat of the US Congress in Washington DC.",
            "The Smithsonian is a group of museums, education, and research centers etc.",
            "The Lincoln Memorial is built to honor the 16th president of the U.S, Abraham Lincoln.",
            "The National Gallery of Art is a national art museum in Washington DC, United States.",
            "It was founded in 1910 and is based in Washington, District of Columbia.",
            "The Washington Monument is an obelisk within the National Mall in Washington DC.",
            "It was established in 1946 as the National Air Museum.",

      };
        readonly string[] Place6 = new string[]
      {
            "Los Angeles County Museum of Art",
            "Disneyland Park",
            "Santa Monica Pier",
            "Griffith Observatory",
            "The Getty",
            "Universal Studios Hollywood",
            "Hollywood Sign",
            "The Huntington Library, Art Museum, and Botanical Gardens",
            "The Broad",

      };

        readonly string[] Place6Description = new string[]
      {
            "It is a visual arts museum that offers a collection of paintings, photography etc.",
            "Disneyland is a theme park in Anaheim, California, which was opened in 1955.",
            "The Santa Monica Pier is a large double jointed pier at the foot of Colorado Avenue.",
            "It is a popular tourist attraction with a close view of the Hollywood Sign.",
            "It is a campus of the Getty Museum & other programs of the Getty Trust. ",
            "The Universal Studios Hollywood is a film studio and theme park.",
            "The Hollywood Sign is an American landmark and cultural icon.",
            "It is a collections-based educational and research institution.",
            "The Broad is a contemporary art museum on Grand Avenue in Los Angeles.",

      };
        readonly string[] Place7 = new string[]
      {
            "Museum of Fine Arts, Boston",
            "Isabella Stewart Gardner Museum",
            "Museum of Science",
            "Fenway Park",
            "Faneuil Hall Marketplace",
            "Boston Children's Museum",
      };

        readonly string[] Place7Description = new string[]
      {
            "It is the 20th largest art museum in the world, measured by the public gallery area.",
            "The Isabella Stewart Gardner Museum is an art museum in Boston, Massachusetts.",
            "The Museum of Science (MoS) is a science museum and indoor zoo in Boston.",
            "Fenway Park is a baseball stadium in Boston, near Kenmore Square. ",
            "The Faneuil Hall is a marketplace and meeting hall located near the waterfront.",
            "Boston Children's Museum is the second oldest children's museum in US.",

      };
        readonly string[] Place8 = new string[]
      {
            "Space Needle",
            "Museum of Pop Culture",
            "Chihuly Garden and Glass",
            "Pike Place Market",
            "Seattle Art Museum",
            "Discovery Park",
      };

        readonly string[] Place8Description = new string[]
      {
            "The Space Needle is an observation tower & Considered to be an icon of the city.",
            "It was founded by Microsoft co-founder Paul Allen in 2000.",
            "The Chihuly Garden and Glass is an exhibit in the Seattle Center.",
            "The Pike Place Market is a public market & opened on August 17, 1907.",
            "Its collections include African arts, American arts, decorative arts etc.",
            "The Discovery Park is a 534-acre park, Washington.",
      };
        readonly string[] Place9 = new string[]
        {
            "Wynwood Walls",
            "Miami Seaquarium",
            "Fairchild Tropical Botanic Garden",
            "Phillip and Patricia Frost Museum of Science",
      };

        readonly string[] Place9Description = new string[]
      {
            "Outdoor museum with creative street art.",
            "The Miami Seaquarium is a 38-acre oceanarium. It was founded in 1955.",
            "Interactive exhibits, classes, and shows.",
            "This park includes the Cape Florida Light.",

      };
        readonly string[] Place10 = new string[]
        {
            "Bellagio Hotel & Casino",
            "MGM Grand",
            "Las Vegas Strip",
            "Red Rock Canyon National Conservation Area",
            "The Mirage",
            "The STRAT Hotel, Casino & SkyPod",
            "The Neon Museum",
            "New York-New York Hotel & Casino",

      };

        readonly string[] Place10Description = new string[]
      {
            "The Bellagio Resort and Casino is a building in Las Vegas, USA.",
            "The MGM Grand Las Vegas is a hotel and casino located on the Las Vegas Strip.",
            "The Las Vegas Strip is a stretch of Las Vegas Boulevard South in Clark County.",
            "It is an area managed by the Bureau of Land Management.",
            "The Mirage is a casino resort on the Las Vegas Strip in Paradise, Nevada.",
            "The Stratosphere Tower is a building in Las Vegas, Nevada, United States.",
            "The Neon Museum features signs from old casinos & other businesses.",
            "Its facilities and services include hotel rooms, entertainment shows etc. ",
      };
        readonly string[] Place11 = new string[]
      {
            "Balboa Park",
            "SeaWorld San Diego",
            "USS Midway Museum",
            "Cabrillo National Monument",
            "La Jolla Cove",

      };

        readonly string[] Place11Description = new string[]
      {
            "Balboa Park is a 1,200-acre historic urban cultural park in San Diego.",
            "SeaWorld San Diego is an animal theme park, oceanarium, outside aquarium.",
            "The USS Midway Museum is a historical naval aircraft carrier museum.",
            "Cabrillo National Monument is at the southern tip of the Point Loma Peninsula.",
            "La Jolla Cove is a small cove with a beach that is surrounded by cliffs in La Jolla.",

      };
        readonly string[] Place12 = new string[]
      {
            "Georgia Aquarium",
            "Zoo Atlanta",
            "Atlanta Botanical Garden",
            "Piedmont Park",
            "Centennial Olympic Park",

      };

        readonly string[] Place12Description = new string[]
      {
            "Its aquarium acts as an aquatic science education institution.",
            "Zoo Atlanta is an Association of Zoos and Aquariums accredited zoological park.",
            "The Atlanta Botanical Garden is a 30 acres botanical garden.",
            "Piedmont Park is an urban park, the land was owned by Dr. Benjamin Walker.",
            "Centennial Olympic Park is a 22-acre public park in downtown Atlanta, Georgia.",

      };
        readonly string[] Place13 = new string[]
      {
            "The National WWII Museum",
            "Jackson Square",
            "Bourbon Street",
            "New Orleans City Park",


      };

        readonly string[] Place13Description = new string[]
      {
            "The National WWII Museum, is a military history museum.",
            "Jackson Square is a historic park in the French Quarter of New Orleans.",
            "Bourbon Street is a historic street in the heart of the French Quarter.",
            "It is the seat of the Roman Catholic Archdiocese of New Orleans.",

      };
        readonly string[] Place14 = new string[]
      {
            "Walt Disney World® Resort",
            "Magic Kingdom Park",
            "Epcot",
            "Disney's Hollywood Studios",
            "Disney's Animal Kingdom Theme Park",
            "Universal Studios Florida",
      };

        readonly string[] Place14Description = new string[]
      {
            "The Walt Disney World Resort, is an entertainment resort complex.",
            "Magic Kingdom Park is a theme park at the Walt Disney World Resort in Bay Lake.",
            "Epcot is a theme park at the Walt Disney World Resort.",
            "Disney's Hollywood Studios is a theme park at the Walt Disney World Resort.",
            "Disney's Animal Kingdom Theme Park is a zoological theme park.",
            "Universal Studios Florida is a theme park and opened to the public on June 7, 1990.",

      };
        readonly string[] Place15 = new string[]
      {
            "Denver Botanic Gardens",
            "Elitch Gardens",
            "Coors Field",
            "Colorado State Capitol",
      };

        readonly string[] Place15Description = new string[]
      {
            "The 23-acre park contains a conservatory, a variety of theme gardens.",
            "Elitch Gardens Theme & Water Park is an amusement park in Denver, Colorado.",
            "Coors Field is a baseball stadium in downtown Denver, Colorado.",
            "The Colorado State Capitol Building, located at 200 East Colfax Avenue in Denver.",
      };
        #endregion
    }

    #endregion
}