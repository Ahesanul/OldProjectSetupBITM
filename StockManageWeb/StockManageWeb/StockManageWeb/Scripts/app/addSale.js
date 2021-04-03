
function getRowForStudent(student) {

    var nameHidden = "<input type='hidden' name='students["+index+"].Name' value='"+student.Name+"' />";
    var contactHidden = "<input type='hidden' name='students["+index+"].Contact' value='"+student.Contact+"' />";
    var ageHidden = "<input type='hidden' name='students["+index+"].Age' value='"+student.Age+"' />";
    var addressHidden = "<input type='hidden' name='students["+index+"].Address' value='"+student.Address+"' />";

    var tr = "<tr>";
    var nameCell = "<td>"+nameHidden+student.Name+"</td>";
    var contactCell = "<td>"+contactHidden+student.Contact+"</td>";
    var ageCell = "<td>"+ageHidden+student.Age+"</td>";
    var addressCell = "<td>"+addressHidden+student.Address+"</td>";
    var endTr = "</tr>";
    var row = tr + nameCell + contactCell + ageCell + addressCell + endTr;

    return row;
}