public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
public static double[] MultiplesOf(double number, int length)
{
    // First Steo: Create a double type array with 'lenght' size.
    // This will hold the multiples of the 'number' as per the length specified.
    double[] result = new double[length];

    // Second Step: Run every i of the array with a for loop, from 0 to length - 1
    for (int i = 0; i < length; i++)
    {
        // Step 3: Calculate the multiple of the 'number' for each i position starting from 1 // (EXAMPLE) - if number = 3, and i = 0 THEN result[0] = 3 * (0 + 1) = 3
        result[i] = number * (i + 1);
    }

    // Fourth step: Return the result array, the whole array.
    return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
public static void RotateListRight(List<int> data, int amount)
{
    // Paso 1: Calculate the index where the last 'amount' elements will be taken from.
    int startIndex = data.Count - amount;

    // Step 2: Using GetRange, obtain those last elements from the list.
    // This will create a new list containing the last 'amount' elements from the original list
    List<int> tail = data.GetRange(startIndex, amount);

    // Step 3: Remove those elements at the end with RemoveRange
    // This will remove the elements from the startIndex to the end of the list.
    data.RemoveRange(startIndex, amount);

    // Step 4: Insert them at the beginning of the list with InsertRange
    // This will insert the tail elements at the start of the list.
    data.InsertRange(0, tail);
}

}
