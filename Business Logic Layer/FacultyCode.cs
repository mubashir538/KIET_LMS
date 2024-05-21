using Data_Access_Layer;
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
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("loadAttendance",cid.ToString());
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
          return dt;
        }
        public DataTable LoadSids(string sid)
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getStudentofID", sid);
            v.ExecuteQuery();
            DataTable dt1 = v.GetDataTable();
            v.CloseConnection();
            return dt1;
        }

        public void MarkAttendance(int cid,bool pr, List<int> ids)
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("loadAttendance", cid.ToString());
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int prs, abs;
                string sid = dt.Rows[i][1].ToString();
                v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("getStudentofCid", cid.ToString(),sid);
                v.ExecuteQuery();
                DataTable dt2 = v.GetDataTable();
                v.CloseConnection();
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

                v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("UpdatePresents", prs, abs, sid, cid);
                v.ExecuteQuery();
                v.CloseConnection();
            }

            MyMessageBox.Show("The Attendance has been Marked");

    }

        public DataTable getCourseInfo(int cid)
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getClasses",cid.ToString());
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
            return dt;
        }

        public DataTable getCourses()
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getClassesofFaculty",Teacher.name);
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
            return dt;

        }

        public string getCourseNames(string courseids)
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getAbreviation", courseids);
            string abr = v.ExecuteValue().ToString();
            v.CloseConnection();
            return abr;
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
