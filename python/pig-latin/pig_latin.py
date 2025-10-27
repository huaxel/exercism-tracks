def translate(text):
    def translate_word(word):
        # rule 1
        if word[0] in "aeiou" or word[:2] in ("xr", "yt"):
            return word + "ay"
        # rule 4
        if word[0] not in "aeiou" and word[1] == "y":
            return word[1:] + word[0] + "ay"
        if word[0] not in "aeiou" and word[1] not in "aeiou" and word[2] == "y":
            return word[2:] + word[:2] + "ay"
        # rule 3
        if word[:2] == "qu":
            return word[2:] + "quay"
        if word[0] not in "aeiou" and word[1:3] == "qu":
            return word[3:] + word[0] + "quay"
        # rule 2
        if word[0] not in "aeiou" and word[1] not in "aeiou" and word[2] not in "aeiou":
            return word[3:] + word[:3] + "ay"
        if word[0] not in "aeiou" and word[1] not in "aeiou":
            return word[2:] + word[:2] + "ay"
        if word[0] not in "aeiou" and word[1] in "aeiou":
            return word[1:] + word[0] + "ay"
        else:
            return word + "ay"

    words = text.split()
    translated_words = [translate_word(word) for word in words]
    return " ".join(translated_words)
