using KIET_LMS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Business_Logic_Layer
{
    public class FacultyCode
    {
        public DataTable LoadAttendance(FlowLayoutPanel flowLayoutPanel,int cid)
        {
            new TouchScrollVertical(flowLayoutPanel);
            string query = string.Format("Select * from Enrolled where Cid = {0}", cid.ToString());
            DataTable dt = databaseConnection.getTable(query);
          return dt;
        }
        public DataTable LoadSids(string sid)
        {
            string query1 = string.Format("Select * from Std where ID = {0}", sid);
            DataTable dt1 = databaseConnection.getTable(query1);
            return dt1;
        }

        public void MarkAttendance(int cid,bool pr, List<int> ids)
        {
            string query = string.Format("Select * from Enrolled where Cid = {0}", cid.ToString());
            DataTable dt = databaseConnection.getTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int prs, abs;
                string sid = dt.Rows[i][1].ToString();
                string q2 = string.Format("select * from Enrolled where Cid = {0} and Sid ={1}"
                    , cid.ToString(), sid);
                DataTable dt2 = databaseConnection.getTable(q2);
                prs = int.Parse(dt2.Rows[0][4].ToString());
                abs = int.Parse(dt2.Rows[0][5].ToString());

                if (pr)
                {
                    bool flag = false;
                    for (int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == int.Parse(sid))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        prs++;
                    }
                    else
                    {
                        abs++;
                    }
                }
                else
                {
                    bool flag = false;
                    for (int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == int.Parse(sid))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        abs++;
                    }
                    else
                    {
                        prs++;
                    }
                }

                string query2 = String.Format("update Enrolled set Present={0},Absents={1} where Sid = {2} and Cid = {3}"
                       , prs, abs, sid, cid);
                databaseConnection.Execute(query2);
            }

            MyMessageBox.Show("The Attendance has been Marked");

    }

        public DataTable getCourseInfo(int cid)
        {
            string query = string.Format("select * from Classes where ClD={0} ", cid.ToString());
            return databaseConnection.getTable(query);
        }

        public DataTable getCourses()
        {
            string querycourses = String.Format("select * from Classes where Faculty='{0}'",
                Teacher.name);
            return databaseConnection.getTable(querycourses);

        }

        public DataTable getCourseNames(string courseids)
        {
            string queryAbrreviation = String.Format("select * from CoursesNames where Courses='{0}'",courseids);
            return databaseConnection.getTable(queryAbrreviation);
        }
        public Color generateColor()
        {
            Color color;
            Random random = new Random();
            int a = random.Next(1, 6);
            if (a == 1)
            {
                color = Color.FromArgb(127, 97, 110);
            }
            else if (a == 2)
            {
                color = Color.FromArgb(90, 108, 114);
            }
            else if (a == 3)
            {
                color = Color.FromArgb(162, 113, 101);
            }
            else if (a == 4)
            {
                color = Color.FromArgb(26, 97, 108);
            }
            else if (a == 5)
            {
                color = Color.FromArgb(80, 47, 64);
            }
            else
            {
                color = Color.FromArgb(85, 91, 91);
            }
            return color;
        }


    }
}
