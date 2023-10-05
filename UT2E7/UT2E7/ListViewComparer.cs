using System;
using System.Collections;
using System.Windows.Forms;

/// <summary>
/// This class is an implementation of the 'IComparer' interface.
/// </summary>
public class ListViewComparer : IComparer
{
    private int ColumnToSort;
    private SortOrder OrderOfSort;
    private CaseInsensitiveComparer ObjectCompare;

    public ListViewComparer()
    {
        ColumnToSort = 0;
        OrderOfSort = SortOrder.None;
        ObjectCompare = new CaseInsensitiveComparer();
    }
    public int Compare(object x, object y)
    {
        int compareResult = 0;
        ListViewItem listviewX, listviewY;

        listviewX = (ListViewItem)x;
        listviewY = (ListViewItem)y;


        switch (ColumnToSort)
        {
            case 0: 
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
                break;
            case 1:
                DateTime d1 = Convert.ToDateTime(listviewX.SubItems[ColumnToSort].Text);
                DateTime d2 = Convert.ToDateTime(listviewY.SubItems[ColumnToSort].Text);
                compareResult = DateTime.Compare(d1, d2);
                break;
            case 2:
                int ix, iy;
                Int32.TryParse(listviewX.SubItems[ColumnToSort].Text, out ix);
                Int32.TryParse(listviewY.SubItems[ColumnToSort].Text, out iy);
                compareResult = ix - iy;
                break;
        }


        switch (OrderOfSort)
        {
            case SortOrder.Ascending:
                return compareResult;
                break;
            case SortOrder.Descending:
                return -compareResult;
                break;
            default:
                return 0;
                break;
        }
    }

    public int SortColumn
    {
        set
        {
            ColumnToSort = value;
        }
        get
        {
            return ColumnToSort;
        }
    }

    public SortOrder Order
    {
        set
        {
            OrderOfSort = value;
        }
        get
        {
            return OrderOfSort;
        }
    }

}