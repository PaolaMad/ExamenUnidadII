using ExamenUnidadII.Models;
using MailKit.Net.Smtp;
using MimeKit;
using static System.Net.Mime.MediaTypeNames;

namespace ExamenUnidadII.Services
{
    public class ServiceMailTrap: IServiceEmail
    {
        public async Task Send(Test model)
        {
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("Gonzalo Monroy", "gonzalo21monroy@gmail.com"));
            email.To.Add(new MailboxAddress(model.Name, model.Email));
            email.Subject = $"Resultado de: {model.Name}";

            if (model.Result <=20)
            {
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {

                    Text = $"<p>MUY BAJO\r\nCon esta puntuación debes saber que todavía no conoces suficientemente qué emociones son las \r\nque vives, no valoras adecuadamente tus capacidades, que seguramente tienes. Son muchas las \r\nhabilidades que no pones en práctica, y son necesarias para que te sientas más a gusto contigo \r\nmismo y para que las relaciones con la gente sean satisfactorias.\r\nAlgunos consejos que podemos brindarte, son los siguientes:\r\n\r\n1.\tConócete a ti mismo y acéptate\r\nUno de los lugares por los que deberías empezar es conociéndote a ti mismo. Puedes hacerte algunas preguntas como: ¿Cuáles son mis fortalezas? ¿Cuáles son mis debilidades? ¿Cuáles son mis limitaciones? ¿Cuáles son las cosas que me agradan y desagradan? ¿Qué nivel de temperamento tengo? ¿Qué nivel de romanticismo y/o sentimentalismo padezco? ¿Cuáles son las cosas que me aterran? ¿Cuál es mi nivel de positivismo? ¿Cuál es mi nivel de negativismo?\r\nSi conocemos nuestras debilidades, podremos arreglarlas. Si conocemos nuestras fortalezas, podremos cultivarlas. \r\n\r\n2.\tSé optimista\r\nEl optimismo requiere que sepas reconocer no sólo tus buenas cualidades, sino también las de los demás. Intenta sacar lo mejor de las situaciones difíciles que surgen diariamente en tú vida. Haz uso del sentido del humor en la medida que sea posible y convéncete a ti mismo de que cualquier dificultad se presenta para mejorarnos como personas.\r\n\r\n3.\tHaz frente a las emociones negativas\r\nEsta puede llegar a ser una de las tareas más complicadas si no estás familiarizado a hacerlo, pero es muy necesario que puedas aprender a enfrentarte a esas emociones para tu bien y el de tu inteligencia emocional. Los sentimientos negativos que generalmente llevan a accionar a este tipo de emociones son: los celos, la envidia, el rencor, desprecios, humillación, soberbia, entre los más importantes.\r\nAprende a ser consciente de esas emociones en ti. Reconocerlas es una buena manera para iniciar.\r\n\r\n4.\tMeditar\r\nLa mayoría de personas no tienen ningún momento en silencio a solas, ya sea por decisión propia o no.  Si temes estar en silencio acompañado únicamente por tus pensamientos, es hora que hagas las pases con la soledad y contigo mismo. Ya sea que poseas una personalidad introvertida o extrovertida, pasar tiempo a solas meditando en silencio es importante para aprender a identificar y gestionar tus emociones.\r\n\r\n\r\n5.\tEscribe tus pensamientos y sentimientos\r\nEscribe todas tus emociones, desquítate en tu escritura con todo aquello que te ha lastimado de alguna forma, escribe las posibles soluciones a tus problemas, escribe sobre alegrías o sentimientos ocultos, desahógate en tu hoja. Escribir es un ejercicio excelente, tanto para el cerebro como para tus emociones.\r\n</p>"

                };
            }else if(model.Result == 21 && model.Result <= 35)
            {

                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {

                    Text = $"<p>BAJO\r\nCon esta puntuación tus habilidades emocionales son todavía escasas. Necesitas conocerte un \r\npoco mejor y valorar más lo que tú puedes ser capaz de hacer. Saber qué emociones \r\nexperimentas, cómo las controlas, cómo las expresas y como las identificas en los demás es \r\nfundamental para que te puedas sentir bien, y desarrollar toda tu personalidad de una manera \r\neficaz.  \r\nAlgunos consejos que podemos brindarte, son los siguientes:\r\n\r\n1.\t No te quedes en el pasado\r\nAl analizar tus emociones, puede llevarte a sobre pensar las causas de ellas. Es bueno saber de donde vienen tus emociones e incluso tus reacciones a situaciones comunes, pero obsesionarte con eventos del pasado pueden traer a flote emociones dañinas que te harán retroceder el avance que has obtenido hasta ahora. ¡Bueno, a despertar! Dejemos el pasado donde pertenece, y tomemos las enseñanzas de nuestros errores como cimientos de nuestro futuro.\r\n\r\n\r\n2.\tExpresa cómo te sientes\r\nSi has empezado a tener claras tus emociones, exteriorizarlas te ayudará a entenderlas aún más. Es importante que escojas bien a una persona que pueda ser capaz de escucharte y ayudarte a sentirte entendido. Como todo al inicio, será difícil. Pero conforme vayas intentándolo, será cada vez más fácil hablarlo y entenderlo. Recuerda que no siempre tendrás las palabras correctas para describir tus emociones, es por eso que la perspectiva de un tercero puede ayudarte a ver las cosas claras. Si lo prefieres, también puedes buscar ayuda profesional.\r\n\r\n3.\tAsume responsabilidad de tus emociones \r\nLas situaciones externas, las acciones de los demás provocarán tus emociones, independientemente de cuales sean, debes reconocer que el surgimiento de ellas es tu responsabilidad. Si bien, son provocadas, somos nosotros quienes decidimos que hacer con ellas. Es parte de la gestión de emociones hacerte cargo, la inteligencia emocional no solamente abarca el reconocimiento sino también el manejo. \r\n</p>"

                };

            }
            else if(model.Result == 36 && model.Result <= 45)
            {

                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {

                    Text = $"<p>MEDIO-BAJO\r\nCasi lo conseguiste. Con esta puntuación te encuentras rayando lo deseable para tus habilidades \r\nemocionales. Ya conoces muchas cosas de lo que piensas, haces y sientes y, posiblemente, de \r\ncómo manejar tus emociones y comunicarte con eficacia con los demás. No obstante, no te \r\nconformes con este puntaje conseguido.\r\nAlgunos consejos que podemos brindarte, son los siguientes:\r\n\r\n1.\tPractica la escucha activa\r\nCuando una persona te cuente algo, prueba escuchar atentamente, en lugar de simplemente esperar a tu turno para hablar. Demuéstrale con tu lenguaje corporal que estás realmente presente en la conversación. Y cada cierto tiempo, verifica que estás entendiendo de manera correcta lo que te está compartiendo. Esto te ayudará no solamente a sentirte identificado, es decir; ser empático, sino que te permitirá detectar emociones en los demás y percibir de manera abierta lo que otras personas sienten. \r\n\r\n2.\tReconoce que es un proceso de toda la vida\r\nLa inteligencia emocional es una habilidad que se desarrolla a lo largo de la vida. Con el tiempo vamos aprendiendo más sobre nosotros mismos, cómo nos relacionamos y cómo son nuestras emociones, lo cual nos permite cultivar esta inteligencia. De la misma forma, a lo largo de la vida se presentan situaciones complicadas que la pueden poner a prueba.\r\n\r\n3.\tPide ayuda si lo necesitas\r\nCultivar la inteligencia emocional no es una tarea fácil. En muchas ocasiones, podemos haber vivido situaciones complejas que interfieren con nuestra capacidad de regular las emociones. Si consideras que ese es el caso, recuerda que siempre es una buena idea pedir ayuda profesional para desarrollar tu inteligencia emocional. \r\n\r\n\r\n\r\n</p>"

                };

            }
            else if(model.Result == 46 && model.Result <= 79)
            {

                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {

                    Text = $"<p>MEDIO-ALTO\r\nNo está nada mal la puntuación que has obtenido. Indica que sabes quién eres, cómo te \r\nemocionas, cómo manejas tus sentimientos y cómo descubres todo esto en los demás. Tus \r\nrelaciones con la gente las llevas bajo control, empleando para ello tus habilidades para saber \r\ncómo te sientes tú, cómo debes expresarlo y también conociendo cómo se sienten los demás, y \r\nqué debes hacer para mantener relaciones satisfactorias con otras personas.\r\nAlgunos consejos que podemos brindarte, son los siguientes:\r\n\r\n1.\tMotívate a seguir aprendiendo \r\nNo te limites con lo que has aprendido a lo largo del tiempo, la experiencia adquirida es buena, pero investigar acerca de la inteligencia emocional puede ayudarte, brindándote herramientas nuevas que puedes aplicar a tu vida. Busca libros, artículos, o páginas web que puedan ayudarte a informarte.\r\n\r\n2.\tAprender de los errores\r\nSi cuentas con más herramientas para aplicar acerca de la inteligencia emocional entonces tendrás nuevas oportunidades para aplicarlos en tu día a día. Aparte de adquirir experiencia probando que métodos pueden llegar a funcionarte, serás capaz de aprender de los errores cometidos a lo largo del proceso de aprendizaje. Reconoce que todos cometemos errores y que el crecimiento personal viene de aprender de ellos. No tengas miedo de equivocarte, en su lugar, analiza lo sucedido y busca maneras de mejorar en el futuro.\r\n\r\n3.\tDisfruta tus emociones\r\nLa idea de disfrutas las emociones puede llegar a ser chocante cuando estamos hablando de emociones como: enojo, ira, tristeza, desaliento, etc. Por eso cabe aclarar que esto realmente es posible, a lo mejor te preguntes como. Cuando decides ser considerado contigo mismo y te permites experimentar cada una de las emociones que presentas de manera prudente y sana, te estás permitiendo disfrutar no solo tus emociones, sino también a ti mismo en cada una de tus versiones y etapas.\r\n</p>"

                };

            }
            else if (model.Result == 80 && model.Result <= 90)
            {

                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {

                    Text = $"<p>MUY ALTO\r\nEres un superhéroe de la emoción y su control. Se diría que eres número 1 en eso de la \r\nINTELIGENCIA EMOCIONAL. Tus habilidades te permiten ser consciente de quién eres, qué \r\nobjetivos pretendes, qué emociones vives, sabes valorarte como te mereces, manejas bien tus \r\nestados emocionales y, además, con más mérito todavía, eres capaz de comunicarte eficazmente \r\ncon quienes te rodean, y también eres único/a para solucionar posconflictos interpersonales que \r\ncada día acontecen.\r\nAlgunos consejos que podemos brindarte, son los siguientes:\r\n1.\tObserva cómo te sientes\r\nEs gratificante que poseas una inteligencia emocional alta, pero es importante recordarte que mantenerla no debe ser una opción. No debes confiarte en “Tengo una inteligencia emocional alta”. Mantenerla estabilizada debería ser de tus prioridades. Piensa en esto como el ejercicio físico, entre más practiques, más obtendrás mejoras. Entre menos lo hagas, tu mente dejará de estar acostumbrada a todo el esfuerzo que le has invertido. Mantén observado tus capacidades, pensamientos, etc.\r\n\r\n\r\n2.\tMotiva a otras personas con baja inteligencia emocional\r\nPoseer una inteligencia emocional alta puede darte una oportunidad para ser una persona impulsadora en la vida de alguien más. Tener esta habilidad te hace poseer empatía hacia ti mismo y hacia los demás. Puedes usarla para ayudar a quiénes necesitan una mano en circunstancias en las que tu podrías brindar un buen consejo.\r\n\r\n3.\tSé consciente de los desencadenantes emocionales\r\nCuida tus emociones ahora más que nunca. Eres capaz de identificar con facilidad los desencadenantes de tus emociones, que las provoca, que las hace retenerse y cuales son positivos o negativos.\r\nDe esta manera serás capaz de saber llevarlo con anticipación. Te dará la ventaja sobre las circunstancias permitiéndote influir sobre las situaciones en vez de que estas influyan en ti.\r\n\r\n4.\tEvita contagios emocionales negativos\r\nAunque no seas consciente, las personas pueden llegar a aprovecharse de tu empatía emocional, y en algunas ocasiones no será de forma intencional, pero en todo caso debes estar atento a que sus emociones no influyan en las tuyas de forma negativa. Extiende tu mano si te es posible, pero asegúrate de poner límites para tu autocuidado.\r\n</p>"

                };

            }


                using (var smtp = new SmtpClient())
            {
                smtp.Connect("sandbox.smtp.mailtrap.io", 587, false);
                smtp.Authenticate("bd726fddd02315", "4e36a355d06faf");

                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }

        }
    }
}
