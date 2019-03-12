using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDB
{
   public static class GenericRead
    {
            //use mysqli connect style instead of PDO
    $link = connectDb();

    //if no key inputted, get all records
    if (!$key) {
        $sql = "SELECT * FROM $dbTableName";

    } else {
        //if $key inputted, get particular record
        //get the primary key column name
        $sql  = "SHOW KEYS FROM $dbTableName WHERE Key_name = 'PRIMARY'";
        $stmt = $link->prepare($sql);
        $stmt->execute();
        $result               = $stmt->fetch(PDO::FETCH_ASSOC);
        $primaryKeyColumnName = $result['Column_name'];
        //find particular record by key
        $sql = "SELECT * FROM $dbTableName WHERE $primaryKeyColumnName=$key";
    }
    $stmt = $link->prepare($sql);
    $stmt->execute();
    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
closeConnection($link);
    //$link->close();
    //error handling
    if (!$result) {
        echo "ERROR: the sql failed to execute. <br>";
        echo "SQL: $sql <br>";
        echo "Error code: " . $stmt->errorCode() . "<br>";
        echo "Error msg: " . $stmt->errorInfo() . "<br>";
        return false;
    }
    $instants = [];
    foreach ($result as $instant) {
        $instant    = new $className($instant);
        $instants[] = $instant;
    }
    //change return depends on $key
    if (!$key) {
        return $instants;
    } else {
        return $instants[0];
    }
    }
    public static class GenericWrite
    {

    }
}
