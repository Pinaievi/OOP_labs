#include <iostream>
#include <random>
#include <algorithm>
#include <vector>

int simulate(int count, double mu, double eta) {
    std::random_device rd;
    std::mt19937 gen(rd());
    std::uniform_real_distribution<> dis(0.0, 1.0);

    int current_size = 0;
    int max_size = 0;

    for (int i = 0; i < count; ++i) {
        bool is_push = (dis(gen) < mu);
        bool is_pop = (dis(gen) < eta);

        if (is_push && !is_pop) {
            current_size++;
        }
        else if (is_pop && !is_push) {
            if (current_size > 0) {
                current_size--;
            }
        }
        max_size = std::max(max_size, current_size);
    }

    return max_size;
}

int main() {
	std::setlocale(LC_ALL, "Ukrainian");

    double mu = 0.4;
    double eta = 0.6;

    int simulation_steps = 100000;
    int num_runs = 100;

    if (mu > eta) {
        std::cerr << "Помилка: Ймовірність додавання (μ=" << mu << ") більша за ймовірність зчитування (η=" << eta << ").";
        return 1;
    }

    double total_max_size = 0;

    for (int i = 0; i < num_runs; ++i) {
        total_max_size += simulate(simulation_steps, mu, eta);
    }

    double average_max_size = total_max_size / num_runs;

    std::cout << "Симуляцiя середнього максимального розмiру стека." << std::endl;
    std::cout << "μ (PUSH): " << mu << ", η (POP): " << eta << std::endl;
    std::cout << "Кiлькiсть крокiв на прогiн: " << simulation_steps << std::endl;
    std::cout << "Кiлькiсть прогонiв: " << num_runs << std::endl;
    std::cout << "Середнiй максимально необхiдний розмiр: " << average_max_size << std::endl;

    return 0;
}