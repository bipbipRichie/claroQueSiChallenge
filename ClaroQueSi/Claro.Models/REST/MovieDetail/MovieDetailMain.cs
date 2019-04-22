using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claro.Models.REST.MovieDetail
{
    public class Entry
    {
        public string group_id { get; set; }
        public string HKS { get; set; }
        public string device_manufacturer { get; set; }
        public string device_id { get; set; }
        public string device_type { get; set; }
        public string device_model { get; set; }
        public string device_category { get; set; }
        public string api_version { get; set; }
        public string authpn { get; set; }
        public string authpt { get; set; }
        public string format { get; set; }
        public string region { get; set; }
    }

    public class Keywords
    {
        public IList<string> keyword { get; set; }
    }

    public class Genre
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
    }

    public class Genres
    {
        public IList<Genre> genre { get; set; }
    }

    public class Talent
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string fullname { get; set; }
    }

    public class Talents
    {
        public IList<Talent> talent { get; set; }
    }

    public class Role
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public Talents talents { get; set; }
    }

    public class Roles
    {
        public IList<Role> role { get; set; }
    }

    public class Format
    {
        public string id { get; set; }
        public string name { get; set; }
        public string types { get; set; }
        public string sell_type { get; set; }
        public string est { get; set; }
    }

    public class Rating
    {
        public string id { get; set; }
        public string code { get; set; }
        public string desc { get; set; }
    }

    public class Countryoforigin
    {
        public string code { get; set; }
        public string desc { get; set; }
    }

    public class Hd
    {
        public string enabled { get; set; }
        public string detail { get; set; }
    }

    public class Profile
    {
        public string audiotype { get; set; }
        public string videotype { get; set; }
        public string screenformat { get; set; }
        public Hd hd { get; set; }
    }

    public class EncoderTecnology
    {
        public object id { get; set; }
        public object desc { get; set; }
    }

    public class RecorderTechnology
    {
        public object id { get; set; }
        public object desc { get; set; }
    }

    public class Proveedor
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
    }

    public class Rights
    {
        public string start_date { get; set; }
        public string end_date { get; set; }
    }

    public class Original
    {
        public string id { get; set; }
        public string desc { get; set; }
    }

    public class Option
    {
        public string group_id { get; set; }
        public string content_id { get; set; }
        public string current_content { get; set; }
        public string option_id { get; set; }
        public string audio { get; set; }
        public string subtitle { get; set; }
        public string option_name { get; set; }
        public string id { get; set; }
        public string desc { get; set; }
        public string label_short { get; set; }
        public string label_large { get; set; }
        public object intro_start_time { get; set; }
        public object intro_finish_time { get; set; }
        public string credits_start_time { get; set; }
        public IList<string> encodes { get; set; }
        public IList<object> fast_play { get; set; }
    }

    public class Options
    {
        public IList<Option> option { get; set; }
        public int count { get; set; }
    }

    public class Language
    {
        public Original original { get; set; }
        public string dubbed { get; set; }
        public string subbed { get; set; }
        public Options options { get; set; }
    }

    public class Media
    {
        public string originaltitle { get; set; }
        public string description_extended { get; set; }
        public string publishyear { get; set; }
        public string boxoffice { get; set; }
        public Rating rating { get; set; }
        public string duration { get; set; }
        public string haspreview { get; set; }
        public Countryoforigin countryoforigin { get; set; }
        public Profile profile { get; set; }
        public string islive { get; set; }
        public object livetype { get; set; }
        public object liveref { get; set; }
        public object channel_number { get; set; }
        public object timeshift { get; set; }
        public EncoderTecnology encoder_tecnology { get; set; }
        public RecorderTechnology recorder_technology { get; set; }
        public object resource_name { get; set; }
        public string rollingcreditstime { get; set; }
        public string rollingcreditstimedb { get; set; }
        public Proveedor proveedor { get; set; }
        public Rights rights { get; set; }
        public Language language { get; set; }
    }

    public class Extendedcommon
    {
        public Keywords keywords { get; set; }
        public Genres genres { get; set; }
        public Roles roles { get; set; }
        public Format format { get; set; }
        public Media media { get; set; }
    }

    public class Ranking
    {
        public int views_count { get; set; }
        public int votes_count { get; set; }
        public int average_votes { get; set; }
    }

    public class Common
    {
        public int position { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string large_description { get; set; }
        public string duration { get; set; }
        public string image_large_alt { get; set; }
        public string image_medium_alt { get; set; }
        public string image_small_alt { get; set; }
        public string image_large { get; set; }
        public string image_medium { get; set; }
        public string image_small { get; set; }
        public string image_still { get; set; }
        public string image_background { get; set; }
        public string image_base_horizontal { get; set; }
        public string image_base_vertical { get; set; }
        public string image_base_square { get; set; }
        public string image_clean_horizontal { get; set; }
        public string image_clean_vertical { get; set; }
        public string image_clean_square { get; set; }
        public string image_sprites { get; set; }
        public string image_frames { get; set; }
        public string date { get; set; }
        public string media_type { get; set; }
        public string title_uri { get; set; }
        public Extendedcommon extendedcommon { get; set; }
        public Ranking ranking { get; set; }
    }

    public class ContentProvider
    {
        public string group_id { get; set; }
        public string provider_id { get; set; }
        public string provider_code { get; set; }
    }

    public class UniversalId
    {
        public IList<ContentProvider> content_providers { get; set; }
        
    }

    public class Group
    {
        public Common common { get; set; }
        public UniversalId universal_id { get; set; }
    }

    public class Response
    {
        public Group group { get; set; }
    }

    public class MovieDetailResponse
    {
        public Entry entry { get; set; }
        public Response response { get; set; }
        public string status { get; set; }
        public string msg { get; set; }
    }


}
