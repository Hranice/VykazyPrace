using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VykazyPrace.Models;

namespace VykazyPrace
{
    /// <summary>
    /// Třída DBInteractor poskytuje metody pro interakci s databází.
    /// Umožňuje získat informace o uživateli, projektech a ukládat záznamy do databáze.
    /// </summary>
    public class DBInteractor
    {
        public User CurrentUser { get; set; } = new();
        public UserInfo CurrentUserInfo { get; set; } = new();
        public VykazyContext db { get; set; } = new();


        /// <summary>
        /// Získá informace o aktuálním uživateli na základě WinUserName.
        /// </summary>
        /// <param name="WinUserName">Windows uživatelské jméno uživatele.</param>
        /// <returns>Objekt UserInfo obsahující informace o uživateli.</returns>
        public UserInfo? GetCurrentUserInfo(string winUserName)
        {
            if (string.IsNullOrWhiteSpace(winUserName))
            {
                throw new ArgumentException("Uživatelské jméno Windows uživatele nesmí být prázdné.", nameof(winUserName));
            }

            return db.UserInfos.FirstOrDefault(u => u.WinUsername == winUserName);
        }

        /// <summary>
        /// Získá aktuálního uživatele na základě jeho osobního čísla (OsCis).
        /// </summary>
        /// <param name="currentUser">Objekt uživatele.</param>
        /// <param name="OsCis">Osobní číslo uživatele.</param>
        /// <returns>Objekt User obsahující informace o uživateli.</returns>
        public User GetCurrentUser(User currentUser, int OsCis)
        {
            currentUser = db.Users.FirstOrDefault(u => u.OsCis == OsCis);
            return currentUser;
        }

        public List<UserInfo> GetAllUsersAuto()
        {
            List<UserInfo> users = new List<UserInfo>();

            users = db.UserInfos.ToList();
            return users;
        }
        public void RemoveProject(Projekty projekt)
        {
            db.Projekties.Remove(projekt);
            db.SaveChanges();
        }
        public void AddProject(Projekty projekt)
        {
            db.Projekties.Add(projekt);
            db.SaveChanges();
        }
        public void SaveProjekt(Projekty projekt)
        {
            db.Projekties.Update(projekt);
            db.SaveChanges();
        }
        public Projekty GetProjektByName(string name)
        {
            Projekty projekt = new();
            projekt = db.Projekties.FirstOrDefault(b => b.NazevProjektu == name);

            return projekt;

        }

        public Zakazky getZakazkaByName(string name)
        {
            Zakazky zak = new();
            zak = db.Zakazkies.FirstOrDefault(b => b.TypZakazky == name);
            return zak;
        }

        public List<Zakazky> GetAllZakazky()
        {
            List<Zakazky> zakazky = new List<Zakazky>();

            zakazky = db.Zakazkies.ToList();
            return zakazky;
        }
        public ProjectArchive GetProjectByProjectIDArchive(string id)
        {
            ProjectArchive? projekt = new();
            projekt = db.ProjectArchives.AsNoTracking().FirstOrDefault(b => b.Id == int.Parse(id));
            return projekt;
        }
        public ZakazkyArchive GetZakazkyArchiveById(string id)
        {
            ZakazkyArchive zak = new();
            zak = db.ZakazkyArchives.FirstOrDefault(b => b.Id.ToString() == id);
            return zak;
        }
        public Zakazky GetZakazkaById(string id)
        {
            Zakazky zakazka = new();
            zakazka = db.Zakazkies.FirstOrDefault(b => b.Id.ToString() == id);
            return zakazka;
        }
        //public List<Log> GetLogs()
        //{
        //    List<Log> logs = new List<Log>();


        //    logs = db.Logs.ToList();





        //    return logs;
        //}

        //public void SaveLog(Log log)
        //{
        //    db.Logs.Add(log);
        //    db.SaveChanges();
        //}
        public UserInfo GetUserInfoByOsCis(int oscis)
        {
            UserInfo ui = new();
            ui = db.UserInfos.FirstOrDefault(b => b.OsCis == oscis);
            return ui;
        }
        /// <summary>
        /// Získá seznam všech projektů z databáze.
        /// </summary>
        /// <returns>Seznam všech projektů.</returns>
        public List<Projekty> GetAllProjects()
        {
            List<Projekty> AllProjects = new();
            AllProjects = db.Projekties.AsNoTracking().ToList();
            return AllProjects;
        }

        /// <summary>
        /// Uloží záznam (Record) do databáze.
        /// </summary>
        /// <param name="record">Záznam, který má být uložen.</param>
        /// <returns>Vrací true, pokud byl záznam úspěšně uložen.</returns>
        public bool SaveRecord(Record record)
        {
            db.Records.Add(record);
            db.SaveChanges();
            return true;
        }

        public void RemoveZakazka(Zakazky zak)
        {
            db.Zakazkies.Remove(zak);
            db.SaveChanges();
        }
        public List<Record> GetRecordsByZakazka(Zakazky zak)
        {
            List<Record> records = new List<Record>();

            var query = from h in db.Records
                        where h.Zakazka == 1 && h.ProjectId == zak.Id.ToString()
                        select h;
            records = query.ToList();

            return records;
        }

        public void CreateZakazka(Zakazky zak)
        {
            db.Zakazkies.Add(zak);
            db.SaveChanges();
        }
        public Zakazky GetZakazkaByOznaceni(string oznaceni)
        {
            Zakazky? zakazka = new Zakazky();
            zakazka = db.Zakazkies.FirstOrDefault(b => b.CisloZakazky.ToString() == int.Parse(oznaceni).ToString());
            return zakazka;
        }

        /// <summary>
        /// Získá projekt z databáze na základě jeho označení (Oznaceni).
        /// </summary>
        /// <param name="oznaceni">Označení projektu.</param>
        /// <returns>Objekt Projekty představující daný projekt.</returns>
        public Projekty GetProjectByOznaceni(string oznaceni)
        {
            Projekty? projekt = new Projekty();
            projekt = db.Projekties.FirstOrDefault(b => b.OznaceniProjektu == oznaceni);
            return projekt;
        }


        public bool RemoveRecord(Record record)
        {
            db.Records.Remove(record);
            db.SaveChanges();
            return true;
        }

        public void removeRecords(List<Record> records)
        {
            db.Records.RemoveRange(records); db.SaveChanges();
        }


        public Record GetRecordByID(string id)
        {
            Record? record = new Record();
            record = db.Records.FirstOrDefault(b => b.Id.ToString() == id);
            return record;
        }
        public Projekty GetProjectByProjectID(string projectID)
        {
            Projekty? projekt = new();
            projekt = db.Projekties.AsNoTracking().FirstOrDefault(b => b.Id.ToString() == projectID);
            return projekt;
        }


        public List<Record> GetRecordsByUser(User user)
        {
            List<Record> records = new();


            var query = from rec in db.Records
                        where rec.OsCis == user.OsCis
                        select rec;

            records = query.ToList();
            return records;
        }

        public User GetUserByOsCis(string oscis)
        {
            User user = new User();

            user = db.Users.FirstOrDefault(b => b.OsCis.ToString() == oscis);


            return user;
        }

        public void RemoveUserAndRecords(User user, List<Record> records)
        {
            db.Records.RemoveRange(records);
            db.UserInfos.Remove(GetUserInfoByOsCis(user.OsCis));
            db.Users.Remove(user);
            db.SaveChanges();


        }

        public void CreateUser(User user, UserInfo userInfo)
        {
            db.UserInfos.Add(userInfo);
            db.Users.Add(user);
            db.SaveChanges();
        }


        public List<Record> GetRecordsByProject(Projekty projekt)
        {
            List<Record> records = new List<Record>();

            var query = from allrecords in db.Records
                        where int.Parse(allrecords.ProjectId) == projekt.Id
                        select allrecords;

            foreach (var rec in query)
            {
                records.Add(rec);
            }

            return records;
        }

        public List<Record> GetRecordsByProjectAndUser(string ProjectId, string OsCis)
        {
            return db.Records
        .Where(record => record.ProjectId == ProjectId && record.OsCis.ToString() == OsCis)
        .ToList();

        }


        public List<Record> GetRecordsByDateAndUser(string date, UserInfo user)
        {
            List<Record> records = new();

            using (var db = new VykazyContext())
            {
                var query = from recs in db.Records.AsNoTracking()
                            where recs.Date == date && recs.OsCis == user.OsCis
                            select recs;

                records = query.ToList();
            }



            return records;
        }

        public List<Record> GetRecordsByDate(string date)
        {
            List<Record> records = new();

            using (var db = new VykazyContext())
            {
                var query = from recs in db.Records.AsNoTracking()
                            where recs.Date == date && recs.OsCis == Form1.dbint.CurrentUserInfo.OsCis
                            select recs;

                records = query.ToList();
            }



            return records;
        }
        public UserInfo GetUserInfoByUserName(string userName)
        {
            UserInfo userInfo = new UserInfo();
            string Jmeno = userName.Split(' ')[0];
            string Prijmení = userName.Split(" ")[1];
            var query = from user in db.UserInfos.AsNoTracking()
                        where user.Jmeno == Jmeno && user.Prijmeni == Prijmení
                        select user;
            userInfo = query.FirstOrDefault();
            return userInfo;
        }

        public List<Record> GetRecordsByDateAndUser(string date, int oscis)
        {

            List<Record> records = new();
            var query = from recs in db.Records.AsNoTracking()
                        where recs.Date == date && recs.OsCis == oscis
                        select recs;

            records = query.ToList();

            return records;
        }

        public List<User> GetAllUsers()
        {
            List<User> allUsers = new();
            var query = from user in db.Users.AsNoTracking()
                        select user;

            allUsers = query.ToList();
            return allUsers;
        }

        public List<Record> GetRecordsAllByDate(string date)
        {
            List<Record> records = new();
            var query = from recs in db.Records.AsNoTracking()
                        where recs.Date == date
                        select recs;

            records = query.ToList();

            return records;
        }
        public List<Record> GetRecordsByDateAndProject(string date, int projectid)
        {
            List<Record> allrecords = new();

            var query = from records in db.Records
                        where records.Date == date && records.ProjectId == projectid.ToString()
                        select records;

            allrecords = query.ToList();

            return allrecords;
        }

        public List<Record> GetAllRecordsByMonthAndUser(string date, UserInfo user)
        {
            List<Record> records = new();
            List<Record> filteredRecords = new();
            var query = from db in db.Records
                        where db.OsCis == user.OsCis
                        select db;
            records = query.ToList();
            foreach (Record record in records)
            {
                if (record.Date.Split("/")[1] == date.Split("/")[1] && record.Date.Split("/")[2] == date.Split("/")[2])
                {
                    filteredRecords.Add(record);
                }
            }
            return filteredRecords;
        }

        public List<Record> GetAllRecords()
        {
            List<Record> records = new();
            var query = from b in db.Records
                        select b;
            records = query.ToList();
            return records;
        }



        /// <summary>
        /// Retrieves a list of records filtered by a specific month and project.
        /// </summary>
        /// <param name="date">The date string in the format "dd/MM/yyyy", used to extract the target month and year.</param>
        /// <param name="projectid">The identifier string for the project to filter the records by.</param>
        /// <returns>A list of records that match the given month and project.</returns>
        public List<Record> GetRecordsByMonthAndProject(string date, string projectid)
        {
            List<Record> allrecords = GetAllRecords();

            string targetMonth = date.Split("/")[1];
            string targetYear = date.Split("/")[2];

            int projectId = Form1.dbint.GetProjectByOznaceni(projectid).Id;

            var filteredRecords = allrecords
                .Where(record => record.Date.Split("/")[2] == targetYear &&
                                 record.Date.Split("/")[1] == targetMonth &&
                                 record.ProjectId == projectId.ToString())
                .ToList();

            return filteredRecords;
        }

        public List<Models.UzReport> DatasourceUzReport(string date, UserInfo user)
        {
            var context = Form1.dbint.GetAllRecordsByMonthAndUser(date, user);
            var projects = Form1.dbint.GetAllProjects();

            var groupedRecords = context
                .GroupBy(r => r.ProjectId)
                .Select(g => new Models.UzReport
                {
                    ProjectID = g.Key,
                    Hours = g.Sum(r => double.TryParse(r.Hours, out double hours) ? hours : 0)
                })
                .ToList();

            return groupedRecords;
        }

    }
}
