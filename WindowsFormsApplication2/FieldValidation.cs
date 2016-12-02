using System.Linq;

public class validation
{
    //postal code and phone number could have additional separate validation rules that check for proper formatting
    public enum types {Name, Phone, Address, Province, City, Email, DLN, DOB, CC, Type, VIN, Mileage, ID, PostalCode, Non};
    public bool validate(string str, types type) {
        switch (type) {
            //alpha ONLY
            case types.Name:
                for (int i = 0; i < str.Length; i++) {
                    if (!char.IsLetter(str[i]) && !char.IsPunctuation(str[i]) && str[i] != ' ')
                            return false;
                }
                return true;
            case types.Province:
                if (str.Length > 30)
                    return false;
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsLetter(str[i]) && str[i] != ' ')
                        return false;
                return true;
            case types.City:
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsLetter(str[i]) && str[i] != ' ')
                        return false;
                return true;
            //numeric ONLY
            case types.Phone:
                if (str.Length != 10)
                    return false;
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsDigit(str[i]) && str[i] != '-')
                        return false;
                return true;
            case types.CC:
            case types.Mileage:
            case types.ID:
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsDigit(str[i]))
                        return false;
                return true;
            //alphaNumeric
            case types.Type:
            case types.Address:
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsLetterOrDigit(str[i]) && str[i] != ' ')
                        return false;
                return true;
            case types.DLN:
            case types.DOB:
            case types.VIN:
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsDigit(str[i]))
                        return false;
                return true;
            case types.PostalCode:
                if (str.Length != 6)
                    return false;
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsLetterOrDigit(str[i]))
                        return false;
                return true;
            //alphaNumeric plus Special Characters
            case types.Email:
                for (int i = 0; i < str.Length; i++)
                    if (!char.IsLetterOrDigit(str[i]) && str[i] != '.' && str[i] != '_')
                        return false;
                return true;
            default:
                return true;
        }
    }
}