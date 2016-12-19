using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SqlProject
{
    class CurrentStop
    {
        private const int TimeBetweenStopsInSeconds = 60;

        public DataTable BusesInAction_Load()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                DateTime currentDateTime = DateTime.Now;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@time", currentDateTime);
                cmd.CommandText = "SELECT * FROM Driving WHERE [Start time] <= @time AND [End time] >= @time";
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable currentlyWorking = new DataTable();
                da.Fill(currentlyWorking);

                DataRow[] currentlyDriving = currentlyWorking.Select();
                DataSet displaySet = new DataSet();
                foreach (var driver in currentlyDriving)
                {
                    DateTime startTime = (DateTime)driver[2];
                    int stopsDriven = 0;
                    while (currentDateTime.Subtract(startTime) >= TimeSpan.FromSeconds(TimeBetweenStopsInSeconds))
                    {
                        stopsDriven++;
                        startTime = startTime.AddSeconds(TimeBetweenStopsInSeconds);
                    }
                    cmd.CommandText = "SELECT Route FROM Bus WHERE [Bus Id] = " + driver[1];
                    con.Open();
                    int routeId = (int)cmd.ExecuteScalar();
                    cmd.CommandText = "SELECT COUNT([Route Id]) FROM Stops WHERE [Route Id] = " + routeId;
                    int stopsTotal = (int)cmd.ExecuteScalar();
                    con.Close();
                    bool direction = true;
                    while (stopsDriven > stopsTotal)
                    {
                        stopsDriven = stopsDriven - stopsTotal;
                        direction = !direction;
                    }

                    if (!direction)
                    {
                        stopsDriven = stopsTotal - stopsDriven;
                    }
                    cmd.CommandText = "SELECT [Stop Id] FROM Stops WHERE [Route Id] = " + routeId + "AND Serial = " +
                                      stopsDriven;
                    con.Open();
                    int stopId = (int)cmd.ExecuteScalar();
                    con.Close();
                    cmd.CommandText = "SELECT A.Firstname, A.Lastname, B.Make, B.Capacity, B.Route, C.Name " +
                                      "FROM Driver A, Bus B, Stop C WHERE A.Id = " + driver[0] + "AND B.[Bus Id] = " +
                                      driver[1] + "AND C.[Stop Id] = " + stopId;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, con);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    displaySet.Tables.Add(dataTable);
                }

                DataTable dtAll = displaySet.Tables[0].Copy();
                for (int i = 1; i < displaySet.Tables.Count; i++)
                {
                    dtAll.Merge(displaySet.Tables[i]);
                }

                return dtAll;
            }
        }
    }
}
