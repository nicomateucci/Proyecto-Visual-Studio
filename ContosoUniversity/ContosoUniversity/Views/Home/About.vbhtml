@ModelType IEnumerable(Of ContosoUniversity.ViewModels.EnrollmentDateGroup)
@Code
    ViewBag.Title = "Student Body Statistics"
End Code

<h2>Student Body Statistics</h2>

<table>
    <tr>
        <th>
            Enrollment Date
        </th>
        <th>
            Students
        </th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.EnrollmentDate)
            </td>
            <td>
                @item.StudentCount
            </td>
        </tr>
    Next
</table>