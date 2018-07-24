import junitparams.JUnitParamsRunner;
import junitparams.Parameters;
import org.junit.Test;
import org.junit.runner.RunWith;

import static org.hamcrest.core.Is.is;
import static org.junit.Assert.assertThat;

@RunWith(JUnitParamsRunner.class)
public class RomanNumeralConverterShould {

    @Test
    public void convert_arabic_numbers_into_their_respective_roman_numeral() {
        int arabic = 1;
        assertThat(RomanNumeralConverter.romanFor(arabic), is("I"));
    }
}