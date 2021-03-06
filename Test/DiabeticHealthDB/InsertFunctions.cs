﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DiabeticHealthDB
{
    public static class InsertFunctions
    {
       /*
      * Inserts info into Demographic Table from from
      */
        public static string InsertIntoDemographics(string FirstName, string LastName, string Gender, string DateofLastVisit, string Street, string City, string State, string Zip, string DOB, string Phone, string PrimaryInsuranceProvider, string SecondaryInsuranceProvider, string PatientNotes)
        {
            string inserted = "";
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
               "INSERT INTO `Demographics`(`FirstName`, `LastName`, `Gender`, `DateofLastVisit`, `Street`, `City`, `State`, `Zip`, `DOB`, `Phone`, `PrimaryInsuranceProvider`, `SecondaryInsuranceProvider`, `PatientNotes`)" +
               "VALUES (@FirstName, @Lastname, @Gender, @DateofLastVisit, @Street, @City, @State, @Zip, @DOB, @Phone, @PrimaryInsuranceProvider, @SecondaryInsuranceProvider, @PatientNotes);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DateofLastVisit", DateofLastVisit);//might drop this one
            cmd.Parameters.AddWithValue("@Street", Street);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.Parameters.AddWithValue("@Zip", Zip);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@PrimaryInsuranceProvider", PrimaryInsuranceProvider);
            cmd.Parameters.AddWithValue("@SecondaryInsuranceProvider", SecondaryInsuranceProvider);
            cmd.Parameters.AddWithValue("@PatientNotes", PatientNotes);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch(MySqlException ex)//perhaps pass exception to message box
            {
                inserted = "Error Has Occured";
               
            }
            finally
            {
                conn.Close();
            }
            return inserted;

        }
        /*
         * Inserts info into AllergyInfo Table from form
         */
        public static string InsertIntoAllergyInfo(int PatientID, string AllergicTo, string Reaction)
        {
            string inserted = "";
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `AllergyInfo`(`PatientID`, `AllergicTo`, `Reaction`) VALUES (@PatientID, @AllergicTO, @Reaction);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@AllergicTo", AllergicTo);
            cmd.Parameters.AddWithValue("@Reaction", Reaction);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {
                inserted = ex.ToString();

            }
            finally
            {
                conn.Close();
            }
            return inserted;

        }
        /*
         *Insert function for VitalsInforamtion Table  
         */
        public static string InsertIntoVitalsInformation(DateTime DateOfTest, int HeartRate, int Systolic, int Diastolic, int RespiratoryRate, int OxygenSaturation, string AirType, int Height, int Weight, double Temperature, int PatientID)
        {
            string inserted = "";
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `VitalsInformation`( `DateofTest`, `HeartRate`, `Systolic`, `Diastolic`, `RespiratoryRate`, `OxygenSaturation`, `AirType`, `Height`, `Weight`, `Temperature`, `PatientID`)" +
                "VALUES (@DateOfTest, @HeartRate, @Systolic, @Diastolic, @RespiratoryRate, @OxygenSaturation, @AirType, @Height, @Weight, @Temperature, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@DateOfTest", DateOfTest);
            cmd.Parameters.AddWithValue("@HeartRate", HeartRate);
            cmd.Parameters.AddWithValue("@Systolic", Systolic);
            cmd.Parameters.AddWithValue("@Diastolic", Diastolic);
            cmd.Parameters.AddWithValue("@RespiratoryRate", RespiratoryRate);
            cmd.Parameters.AddWithValue("@OxygenSaturation", OxygenSaturation);
            cmd.Parameters.AddWithValue("@AirType", AirType);
            cmd.Parameters.AddWithValue("@Height", Height);
            cmd.Parameters.AddWithValue("@Weight", Weight);
            cmd.Parameters.AddWithValue("@Temperature", Temperature);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {
                inserted = ex.ToString();
                

            }
            finally
            {
                conn.Close();
            }
            return inserted;
        }
        /*
       *Insert function for Medication Table  
       */
        public static string InsertIntoMedication(string MedicationName, string DateStarted, string Amount, string Frequency, string Route, int PatientID)
        {
            string inserted = "";
            
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `Medication`( `MedicationName`, `DateStarted`, `Amount`, `Frequency`, `Route`, `PatientID`)" +
                "VALUES (@MedicationName, @DateStarted, @Amount, @Frequency, @Route, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
            cmd.Parameters.AddWithValue("@DateStarted", DateStarted);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@Route", Route);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {

                inserted = ex.ToString();

            }
            finally
            {
                conn.Close();
            }
            return inserted;

        }
        /*
       *Insert function for Diabetic Medication Table  
       */
        public static string InsertIntoDiabetesMedication(string MedicationName, string DateStarted, string Amount, string Frequency, string Route, int PatientID)
        {
            string inserted = "";

            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `DiabetesMedication`( `MedicationName`, `DateStarted`, `Amount`, `Frequency`, `Route`, `PatientID`)" +
                "VALUES (@MedicationName, @DateStarted, @Amount, @Frequency, @Route, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
            cmd.Parameters.AddWithValue("@DateStarted", DateStarted);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@Route", Route);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {

                inserted = ex.ToString();

            }
            finally
            {
                conn.Close();
            }
            return inserted;

        }
        /*
       *Insert function for LipidTest  
       */
        public static string InsertIntoLipidTest(DateTime DateOfTest, double HgA1C, double Cholesterol, double HDL, double LDL, double Triglycerides, int PatientID)
        {
            string inserted = ""; 
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `LipidTestInformation`( `DateOfTest`, `HgA1C`, `Cholesterol`, `HDL`, `LDL`, `Triglycerides`, `PatientID`)" +
                "VALUES (@DateOfTest, @HgA1C, @Cholesterol, @HDL, @LDL, @Triglycerides, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@DateOfTest", DateOfTest);
            cmd.Parameters.AddWithValue("@HgA1C", HgA1C);
            cmd.Parameters.AddWithValue("@Cholesterol", Cholesterol);
            cmd.Parameters.AddWithValue("@HDL", HDL);
            cmd.Parameters.AddWithValue("@LDL", LDL);
            cmd.Parameters.AddWithValue("@Triglycerides", Triglycerides);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {

                inserted = ex.ToString();

            }
            finally
            {
                conn.Close();
            }
            return inserted;

        }
        /*
       *Insert function for Diabetes Background  
       */
        public static string InsertIntoDiabetesBackground(string DateInfoTaken, string DateDiagnosed, string DiabetesType, int PatientID)
        {
            string inserted = "";
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `DiabetesBackground`( `DateInfoTaken`, `DateDiagnosed`, `DiabetesType`, `PatientID`)" +
                "VALUES (@DateInfoTaken, @DateDiagnosed, @DiabetesType, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@DateInfoTaken", DateInfoTaken);
            cmd.Parameters.AddWithValue("@DateDiagnosed", DateDiagnosed);
            cmd.Parameters.AddWithValue("@DiabetesType", DiabetesType);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {

                inserted = ex.ToString();

            }
            finally
            {
                conn.Close();
                
            }
            return inserted;

        }

        /*
       *Insert function for DiabeticTests
       */
        public static string InsertIntoDiabeticTests(string DateOfTest, string Microalbumin, string FootCheck, string CurrentYearVaccination, string DiabeticEyeExam, string NutritionalCounseling, int PatientID)
        {
            string inserted = "";
            MySqlConnection conn = DatabaseConnection.GetConnection();
            string qry =
                "INSERT INTO `DiabeticTests`( `DateOfTest`, `Microalbumin`, `FootCheck`, `CurrentYearVaccination`, `DiabeticEyeExam`, `NutritionalCounseling`, `PatientID`)" +
                "VALUES (@DateOfTest, @Microalbumin, @FootCheck, @CurrentYearVaccination, @DiabeticEyeExam, @NutritionalCounseling, @PatientID);";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@DateOfTest", DateOfTest);
            cmd.Parameters.AddWithValue("@Microalbumin", Microalbumin);
            cmd.Parameters.AddWithValue("@FootCheck", FootCheck);
            cmd.Parameters.AddWithValue("@CurrentYearVaccination", CurrentYearVaccination);
            cmd.Parameters.AddWithValue("@DiabeticEyeExam", DiabeticEyeExam);
            cmd.Parameters.AddWithValue("@NutritionalCounseling", NutritionalCounseling);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                inserted = "Successfully Inserted";
            }
            catch (MySqlException ex)//perhaps pass exception to message box
            {

                inserted = ex.ToString();

            }
            finally
            {
                conn.Close();
            }
            return inserted;

        }



    }

  
}


