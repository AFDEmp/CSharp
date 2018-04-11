using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEx3
{
    public static class BlogPostGenerator
    {
        public static List<BlogPost> GetBlogPosts()
        {
            Guid id1 = Guid.Parse("1181B585-26CB-4E32-B773-AD753BD587F5");
            Guid id2 = Guid.Parse("8B332881-16A0-4EA0-B8BE-ED6349F80744");

            //List<BlogPost> result = new List<BlogPost>();
            //result.Add(new BlogPost
            //{
            //    Id = Guid.NewGuid(),
            //    Title = "Lorem ipsum dolor sit amet.",
            //    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque euismod metus vitae mi fringilla, eu sollicitudin augue vehicula. Nulla luctus nibh et diam placerat, id porta nunc faucibus. Praesent nec metus dui. Ut mattis ante a elementum finibus. Proin eu feugiat metus, et sollicitudin tellus. Nunc in rhoncus mauris. Duis ac lectus quam. Morbi a ultrices elit. Vivamus in tincidunt ex. Quisque sit amet nisl eu odio ullamcorper dictum ac et neque. Donec suscipit dictum nulla. Pellentesque posuere tempor orci nec aliquet. Duis vitae nibh fermentum, sollicitudin odio id, aliquet nulla. Nulla vitae dictum dolor. Suspendisse vel turpis nibh.",
            //    User = new User
            //    {
            //        Id = id1,
            //        Username = "mnikolaidis"
            //    }
            //});
           
            //return result;

            return new List<BlogPost>
            {
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque euismod metus vitae mi fringilla, eu sollicitudin augue vehicula. Nulla luctus nibh et diam placerat, id porta nunc faucibus. Praesent nec metus dui. Ut mattis ante a elementum finibus. Proin eu feugiat metus, et sollicitudin tellus. Nunc in rhoncus mauris. Duis ac lectus quam. Morbi a ultrices elit. Vivamus in tincidunt ex. Quisque sit amet nisl eu odio ullamcorper dictum ac et neque. Donec suscipit dictum nulla. Pellentesque posuere tempor orci nec aliquet. Duis vitae nibh fermentum, sollicitudin odio id, aliquet nulla. Nulla vitae dictum dolor. Suspendisse vel turpis nibh.",
                    User = new User
                    {
                        Id = id1,
                        Username = "mnikolaidis"
                    }
                },
                new BlogPost
                {
                    Id = Guid.Parse("18CF7969-98E0-40C9-9AFF-BE45DEA97E72"),
                    Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Body = "Nulla sem tellus, sodales ac dui eget, dapibus sagittis mauris. Mauris metus ex, iaculis sit amet nisi sed, luctus facilisis justo. Ut ullamcorper ex in justo bibendum, maximus pellentesque magna varius. Aenean finibus leo eu orci varius ultricies. Donec pretium, lorem quis viverra condimentum, est nibh auctor felis, eget dictum eros est in lorem. Aliquam et velit libero. Pellentesque sed risus eu augue tristique aliquam quis et leo. Vivamus imperdiet aliquet erat a aliquam. Curabitur at blandit elit, in porta ex. Mauris volutpat, odio quis commodo luctus, quam nulla facilisis lacus, at lobortis libero arcu ut metus. Nunc id turpis vitae ipsum iaculis maximus. Proin lacinia gravida est, egestas semper ante scelerisque non.",
                    User = new User
                    {
                        Id = id1,
                        Username = "mnikolaidis"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Etiam hendrerit mi tincidunt, elementum lorem quis, vehicula tellus.",
                    Body = "Phasellus ac feugiat ex, vel viverra ex. Curabitur hendrerit pulvinar dolor, non varius metus iaculis ut. Integer quis varius nibh, vel blandit velit. Aliquam fringilla quis neque vel dapibus. Nam a lorem enim. Donec lorem nisi, cursus eget egestas vel, interdum non justo. Curabitur varius, eros vel imperdiet vehicula, nibh purus pretium tellus, vitae pretium elit mi a nisl. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse aliquam, arcu vel suscipit ultrices, orci nisl molestie turpis, et blandit eros augue vel lectus. Integer tempus nisi sem, a condimentum erat condimentum id. Ut massa elit, eleifend ut venenatis quis, tempus a lacus.",
                    User = new User
                    {
                        Id = id1,
                        Username = "mnikolaidis"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "In rutrum mi vel lobortis finibus.",
                    Body = "Aenean dignissim venenatis nisl, quis tincidunt lacus sodales eget. Morbi augue risus, euismod ut vestibulum in, maximus non massa. Praesent quis molestie lorem, et tincidunt magna. Integer placerat eget erat nec efficitur. Sed porttitor lectus nulla, ullamcorper volutpat tellus ornare id. Duis rutrum viverra urna, quis suscipit neque vulputate sit amet. Sed vulputate, velit in imperdiet sagittis, dui arcu porta elit, at sagittis erat leo at odio. Mauris sodales lacinia enim, gravida accumsan tortor interdum vel. Nullam elementum efficitur erat sit amet congue. Sed interdum feugiat ex. Duis feugiat feugiat ligula vitae rhoncus. Proin et urna felis. Maecenas eu tortor aliquam tellus laoreet eleifend.",
                    User = new User
                    {
                        Id = id1,
                        Username = "mnikolaidis"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Phasellus vitae augue nec odio accumsan venenatis id eget odio.",
                    Body = "Vestibulum porta metus tincidunt urna accumsan sodales. Proin gravida congue nisi ac interdum. Vestibulum auctor quam enim, at gravida ex ultricies eu. Aliquam dictum lacus ac pulvinar placerat. Maecenas vel dignissim ipsum, nec consequat risus. Curabitur sed porta orci. Sed venenatis ultrices magna, ut gravida nulla commodo non. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Proin ullamcorper aliquet nunc, eget venenatis mi porta ut.",
                    User = new User
                    {
                        Id = id2,
                        Username = "gpapadopoulos"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Sed ultrices turpis ut iaculis lacinia.",
                    Body = "Donec nec tincidunt sem. Quisque risus risus, placerat eu mollis et, posuere ac purus. Pellentesque ultrices tristique leo sed feugiat. Suspendisse non porttitor ante, non condimentum mauris. Integer a diam quis massa pulvinar ullamcorper eu ut erat. Cras mi ante, interdum a dignissim sed, rutrum sit amet neque. Phasellus maximus porta erat. Mauris eget lorem a ex vehicula cursus vel et enim. Donec aliquet eros ut lectus pulvinar, et convallis erat consectetur. Donec mollis, nulla a dictum sollicitudin, nibh massa auctor felis, ac elementum lorem nisi vitae eros. Suspendisse potenti. Curabitur aliquam, risus gravida consequat molestie, quam neque egestas velit, ac rutrum eros lectus sed neque. Sed maximus purus at vestibulum ultricies. Aliquam erat volutpat. Nunc elementum ex nisi, nec luctus arcu iaculis ac.",
                    User = new User
                    {
                        Id = id2,
                        Username = "gpapadopoulos"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "In vitae risus id lectus tempus blandit.",
                    Body = "Cras non tellus id ante vehicula malesuada. Aenean hendrerit risus sapien, eu mattis lacus bibendum sit amet. Suspendisse a posuere est. Interdum et malesuada fames ac ante ipsum primis in faucibus. Integer ac libero sodales, interdum neque porta, facilisis nulla. Nunc tincidunt urna eu bibendum tristique. Curabitur consequat felis ut massa ullamcorper faucibus sed nec purus. Duis tincidunt euismod turpis, eget gravida ligula bibendum sagittis. Nullam libero justo, venenatis sit amet nulla id, sodales faucibus neque. Donec pretium, magna nec rutrum congue, nulla lorem dictum metus, nec dictum sapien leo nec magna. Sed interdum, mi sed imperdiet fermentum, quam sem laoreet erat, sit amet interdum eros nibh porta augue. Phasellus eu lacinia nunc. Nunc vel laoreet enim, eu vulputate leo. Donec mi arcu, scelerisque rutrum diam ut, lobortis ullamcorper urna. Duis dapibus vitae eros ac facilisis.",
                    User = new User
                    {
                        Id = id1,
                        Username = "mnikolaidis"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Sed pellentesque lorem ac eros consectetur, nec interdum neque sollicitudin.",
                    Body = "Nulla ullamcorper lectus a sem posuere, in ultrices est feugiat. Suspendisse eget mi sem. Sed ac dapibus elit. Morbi vitae efficitur lacus. Aenean dapibus gravida erat, sed varius urna laoreet in. Sed euismod odio dolor, vel consectetur leo pellentesque sit amet. Donec gravida, velit non varius bibendum, turpis diam efficitur arcu, non efficitur augue quam et mauris. Suspendisse potenti. Sed luctus enim sit amet odio porta scelerisque. Integer est est, efficitur eget sodales in, egestas id diam. Phasellus interdum ipsum et accumsan lobortis. Ut sit amet leo eget augue vulputate bibendum eu quis enim.",
                    User = new User
                    {
                        Id = id1,
                        Username = "mnikolaidis"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Aenean scelerisque felis sed lorem dictum, ut molestie erat porta.",
                    Body = "Pellentesque porta magna at tempor posuere. Phasellus consequat bibendum ante vel pellentesque. Nullam tincidunt mi eget diam ornare, vitae posuere ipsum dignissim. Integer urna mauris, vulputate ac sodales blandit, ultrices quis nisi. Suspendisse et libero et ligula dignissim scelerisque. Etiam tellus tortor, tempus quis feugiat eu, lacinia eget orci. Nulla sollicitudin molestie eros eget gravida. Vivamus quis augue et ipsum laoreet malesuada. Etiam tincidunt ex eu enim congue imperdiet. Duis laoreet purus sit amet sem scelerisque imperdiet. Vivamus ut eros in turpis facilisis blandit ac ac sem. Phasellus maximus dignissim ullamcorper. Vivamus tellus risus, cursus et fermentum sed, convallis et lectus. Fusce sodales felis eu nunc aliquam, viverra rhoncus orci luctus. Nullam neque erat, bibendum et turpis ac, aliquam tincidunt metus.",
                    User = new User
                    {
                        Id = id2,
                        Username = "gpapadopoulos"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Nulla aliquet dui imperdiet leo tempor, ut dignissim libero elementum.",
                    Body = "Ut tempus sit amet nunc nec efficitur. Nullam et enim gravida, pharetra ante sit amet, fringilla magna. Ut sem ligula, rutrum sed malesuada vitae, egestas ac augue. Integer non volutpat purus, vitae bibendum neque. Vestibulum risus libero, rutrum nec magna quis, ultricies dictum lectus. Mauris fermentum elit eu nunc laoreet pellentesque. Aliquam vitae neque est. Nam vestibulum risus aliquet eros porttitor viverra. Duis tortor diam, dapibus sit amet suscipit at, posuere vitae mi. Nunc mi ipsum, interdum non nisl eget, fringilla placerat neque.",
                    User = new User
                    {
                        Id = id2,
                        Username = "gpapadopoulos"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Sed luctus est non tincidunt pulvinar.",
                    Body = "Nullam mi tellus, ultricies sit amet ipsum sit amet, tincidunt accumsan nibh. Duis vel lacus tincidunt, euismod purus nec, porta mauris. Curabitur vitae nunc dui. Suspendisse lobortis, purus sit amet hendrerit sagittis, magna urna hendrerit dui, in tempor libero odio id quam. Curabitur placerat odio velit, sed iaculis lacus mattis non. Quisque mi risus, pulvinar sit amet vestibulum id, ullamcorper eget eros. Ut fermentum pharetra mauris ac accumsan. Praesent tellus nisi, ullamcorper a nibh sed, pellentesque luctus nisl.",
                    User = new User
                    {
                        Id = id2,
                        Username = "gpapadopoulos"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Donec nec diam at nunc ornare congue quis vel magna.",
                    Body = "Mauris in fermentum nunc, fermentum interdum dui. Integer mattis, justo sed molestie tempor, ipsum felis maximus nisl, facilisis convallis velit nisi quis purus. Sed interdum placerat pretium. Sed malesuada, leo ut bibendum venenatis, nibh nunc aliquet enim, nec tincidunt ex sem id velit. Pellentesque dapibus, est in iaculis faucibus, lectus lectus consequat odio, a blandit velit leo vel ipsum. Ut vel quam leo. Integer tristique felis ut sem laoreet sollicitudin. Interdum et malesuada fames ac ante ipsum primis in faucibus. Suspendisse mollis, tortor eu auctor laoreet, sem libero egestas odio, in convallis augue lacus a ex. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla nec eros ipsum. Donec vel neque velit. Nulla finibus, mi eget suscipit pulvinar, lorem urna tempor odio, quis egestas erat nisi in libero. In hac habitasse platea dictumst.",
                    User = new User
                    {
                        Id = id2,
                        Username = "gpapadopoulos"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Suspendisse interdum neque at lorem tempus sollicitudin.",
                    Body = "Nulla euismod et quam id luctus. Suspendisse tristique bibendum vehicula. Donec a purus mollis, placerat leo ut, lobortis quam. Maecenas placerat odio diam, ut semper magna pretium in. Maecenas vel turpis leo. Curabitur hendrerit risus at consequat maximus. Ut id efficitur ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Pellentesque fermentum metus ac tortor varius, sit amet eleifend neque pellentesque. Nulla eget lorem diam.",
                    User = new User
                    {
                        Id =  id2,
                        Username = "gpapadopoulos"
                    }
                },
                new BlogPost
                {
                    Id = Guid.NewGuid(),
                    Title = "Suspendisse interdum purus commodo, accumsan leo et, aliquet mauris.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare lectus sit amet ligula mollis rhoncus. Nulla dignissim diam sed mauris rutrum elementum. Suspendisse eget sapien eget erat imperdiet feugiat quis quis libero. Nulla in lobortis velit, eu placerat lectus. Aliquam maximus tempor nisl in viverra. Proin eu leo non quam gravida dapibus. Nulla dictum vestibulum magna sed laoreet. Vestibulum magna erat, viverra ut placerat in, volutpat at lorem. Vivamus ut sapien nec dui porta lobortis. Duis tempus risus ut mauris dignissim, id commodo libero pretium.",
                    User = new User
                    {
                        Id = id2,
                        Username = "gpapadopoulos"
                    }
                }
,            };
        }
    }
}
