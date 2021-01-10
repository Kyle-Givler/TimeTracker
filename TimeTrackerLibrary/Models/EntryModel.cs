/*
MIT License

Copyright(c) 2020 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

namespace TimeTrackerLibrary.Models
{
    public class EntryModel
    {
        /// <summary>
        /// Id of the row in the database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Project Associated with this Entry
        /// </summary>
        public ProjectModel Project { get; set; }

        /// <summary>
        /// Row id of the project associated with this entry
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// Date of the Entry
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Returns formatted date
        /// </summary>
        public string FormattedDate 
        {
            get
            {
                return Date.ToString("D");
            }
        }

        /// <summary>
        /// Number of hours spent for this Entry
        /// </summary>
        public double HoursSpent { get; set; }

        /// <summary>
        /// Notes associated with this Entry
        /// </summary>
        public string Notes { get; set; }
    }
}
