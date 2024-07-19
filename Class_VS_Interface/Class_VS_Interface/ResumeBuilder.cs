using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf.parser.clipper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface
{
    public class Resume
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public String[] Education { get; set; } = new string[0];

        public String[] Experience { get; set; } = new string[0];

        public String[] Intrest { get; set; } = new string[0];

        public String[] Skills { get; set; } = new string[0];

        public Resume() { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {FirstName} {LastName}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"Phone Number: {PhoneNumber}");
            sb.AppendLine($"Address: {Address}");

            sb.AppendLine("Education:");
            foreach (var edu in Education)
            {
                sb.AppendLine($" - {edu}");
            }

            sb.AppendLine("Experience:");
            foreach (var exp in Experience)
            {
                sb.AppendLine($" - {exp}");
            }

            sb.AppendLine("Interests:");
            foreach (var interest in Intrest)
            {
                sb.AppendLine($" - {interest}");
            }

            sb.AppendLine("Skills:");
            foreach (var skill in Skills)
            {
                sb.AppendLine($" - {skill}");
            }

            return sb.ToString();
        }


    }



    internal class ResumeBuilder
    {

        private Resume _resume = new Resume();
        Document pdf = new Document();
        Font paraFont = new Font(Font.FontFamily.HELVETICA, 16f);
        public void createPDF()
        {
            PdfWriter.GetInstance(pdf, File.Create("resume.pdf"));
            pdf.Open();
            pdf.NewPage();
        }

        public ResumeBuilder()
        {


        }


        public ResumeBuilder addName(string firstName, string lastName)
        {
            _resume.FirstName = firstName;
            _resume.LastName = lastName;

            var header = firstName + "  " + lastName;
            var para = new Paragraph(header, paraFont);
            pdf.Add(para);

            return this;

        }

        public ResumeBuilder addEduction(String[] eduction)
        {
            _resume.Education = eduction;


            pdf.Add(new Paragraph("Education", paraFont));
            foreach (var edu in eduction)
            {
                pdf.Add(new Phrase(edu));
            }
            pdf.Add(Chunk.NEWLINE);
            pdf.Add(Chunk.NEWLINE);


            return this;


        }

        public ResumeBuilder addSkills(String[] skills)
        {
            _resume.Skills = (skills);

            pdf.Add(new Paragraph("Skills", paraFont));
            foreach (var skill in skills)
            {
                pdf.Add(new Phrase(skill));
                pdf.Add(Chunk.NEWLINE);
            }
            pdf.Add(Chunk.NEWLINE);

            return this;


        }

        public ResumeBuilder addExperience(string[] experience)
        {
            _resume.Experience = experience;

            pdf.Add(new Paragraph("Experience", paraFont));
            foreach (var exp in experience)
            {
                pdf.Add(new Phrase(exp));
                pdf.Add(Chunk.NEWLINE);
            }
            pdf.Add(Chunk.NEWLINE);

            return this;
        }

        public ResumeBuilder addIntrest(string[] interest)
        {
            _resume.Intrest = interest;

            pdf.Add(new Paragraph("Interest", paraFont));
            foreach (var item in interest)
            {
                pdf.Add(new Phrase(item));
                pdf.Add(Chunk.NEWLINE);
            }
            pdf.Add(Chunk.NEWLINE);

            return this;


        }

        public ResumeBuilder addContactDetails(string email, string phoneNumber, string address)
        {
            _resume.Email = email;
            _resume.PhoneNumber = phoneNumber;
            _resume.Address = address;

            var header = "      " + email + "/" + phoneNumber + "/" + address;
            var para = new Paragraph(header, paraFont);
            pdf.Add(para);
            pdf.Add(Chunk.NEWLINE);
            pdf.Add(new LineSeparator());
            pdf.Add(Chunk.NEWLINE);

            //pdf.Add(new Paragraph("Address", paraFont));
            //pdf.Add(new Phrase(address));
            pdf.Add(Chunk.NEWLINE);
            pdf.Add(Chunk.NEWLINE);

            return this;


        }

        public void closePDF()
        {
            pdf.Close();
        }

        public Resume Build() { return _resume; }

    }
}
