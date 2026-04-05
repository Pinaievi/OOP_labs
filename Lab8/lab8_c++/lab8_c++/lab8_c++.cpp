#include<iostream>
#include<vector>
#include<algorithm>
#include<list>
#include<set>

using namespace std;

int find_longest_series_in_list(const std::list<int>& row) {
    if (row.empty()) {
        return 0;
    }

    int current_series = 1;
    int max_series = 1;

    auto it = row.begin();
    int current_element = *it;
    ++it;

    while (it != row.end()) {
        if (*it == current_element) {
            current_series++;
        }
        else {
            max_series = std::max(max_series, current_series);
            current_series = 1; 
            current_element = *it;
        }
        ++it;
    }
    return std::max(max_series, current_series);
}

void solveMatrixTask() {
    std::cout << "1 завдання" << std::endl;


    std::vector<std::list<int>> matrix = {
        {1, 2, 3, 4, 5},     
        {1, 1, 1, 2, 5},     
        {2, 2, 1, 1, 3},     
        {13, 11, 15, 11, 1}, 
        {1, 3, 3, 3, 3}  
    };

    int max_series_length = 0;
    int row_index_with_max_series = -1;

    for (size_t i = 0; i < matrix.size(); ++i) {

        int current_row_max = find_longest_series_in_list(matrix[i]);


        if (current_row_max > max_series_length) {
            max_series_length = current_row_max;
            row_index_with_max_series = i;
        }
    }

    std::cout << "Row with max row numbers " << row_index_with_max_series << std::endl;
}

bool is_greater_than_50(int n) {
    return n > 50;
}

template <typename Container>
void print_container(const std::string& name, const Container& cont) {
    cout << name << " (" << cont.size() << " елементiв): { ";
    for (const auto& elem : cont) {
        cout << elem << " ";
    }
    cout << "}" << endl;
}

void secondTask() {
    std::cout << "2 завдання" << std::endl;
    std::list<int> c1 = { 85, 12, 60, 5, 99, 45, 10, 72 };
    std::set<int> c2;

    c1.sort(std::greater<int>());

    cout << "\n2, 3. C1 вiдсортований по спаданню:" << endl;
    print_container("C1", c1);

    auto found_pos = std::find_if(c1.begin(), c1.end(), is_greater_than_50);
    if (found_pos != c1.end()) {
        cout << "4. Перший елемент > 50 знайдено: " << *found_pos << endl;
    }

    for (int elem : c1) {
        if (is_greater_than_50(elem)) {
            c2.insert(elem);
        }
    }

    cout << "\n6. C2 (set) мiстить елементи > 50:" << endl;
    print_container("C2", c2);

    c1.sort();

    cout << "8. C1 та C2 вiдсортованi по зростанню:" << endl;
    print_container("C1", c1);
    print_container("C2", c2);

    std::vector<int> c3(c1.size() + c2.size());
    std::merge(c1.begin(), c1.end(), c2.begin(), c2.end(), c3.begin());

    cout << "\n10. C3 (злиття C1 + C2):" << endl;
    print_container("C3", c3);

    long count_match = std::count_if(c3.begin(), c3.end(), is_greater_than_50);
    cout << "11. Кiлькiсть елементів > 50 у C3: " << count_match << endl;

    auto present = std::find_if(c3.begin(), c3.end(), is_greater_than_50);
    if (present != c3.end()) {
        cout << "12. Елемент, що задовольняє умовi, у C3 є." << endl;
    }
    else {
        cout << "12. Елемента, що задовольняє умовi, у C3 немає." << endl;
    }
}

int main() {
	setlocale(LC_ALL, "Ukrainian");

    solveMatrixTask();

    secondTask();
    return 0;
}